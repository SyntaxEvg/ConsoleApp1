using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ILExtractor;

// ==================== СТРУКТУРЫ ДЛЯ СЛОВАРЯ ====================

enum ElementType
{
    Type,
    Field,
    Method,
    Property,
    Event,
    Parameter,
    Local
}

class NameMapping
{
    public string OriginalFullName { get; set; } = "";
    public string OriginalShortName { get; set; } = "";
    public string CleanName { get; set; } = "";
    public ElementType ElementType { get; set; }
    public string Description { get; set; } = "";
    public string? DeclaringType { get; set; }
}

// ==================== ПРОФИЛИРОВАНИЕ ====================

class Profiler
{
    private readonly Dictionary<string, Stopwatch> _watches = new();
    private readonly Dictionary<string, int> _counts = new();
    private readonly Dictionary<string, long> _totalMs = new();
    
    public void Start(string name)
    {
        if (!_watches.ContainsKey(name))
        {
            _watches[name] = new Stopwatch();
            _counts[name] = 0;
            _totalMs[name] = 0;
        }
        _watches[name].Restart();
    }
    
    public void Stop(string name)
    {
        if (_watches.TryGetValue(name, out var sw))
        {
            sw.Stop();
            _totalMs[name] += sw.ElapsedMilliseconds;
            _counts[name]++;
        }
    }
    
    public void Log(string name, string message)
    {
        if (_watches.TryGetValue(name, out var sw))
        {
            Console.WriteLine($"[{sw.ElapsedMilliseconds,6}ms] {name}: {message}");
        }
    }
    
    public void PrintSummary()
    {
        Console.WriteLine();
        Console.WriteLine("========== PROFILER SUMMARY ==========");
        Console.WriteLine($"{"Operation",-30} {"Calls",10} {"Total ms",12} {"Avg ms",10}");
        Console.WriteLine(new string('-', 65));
        
        foreach (var kvp in _totalMs.OrderByDescending(x => x.Value))
        {
            var name = kvp.Key;
            var total = kvp.Value;
            var count = _counts[name];
            var avg = count > 0 ? (double)total / count : 0;
            Console.WriteLine($"{name,-30} {count,10} {total,12} {avg,10:F2}");
        }
        Console.WriteLine("=======================================");
    }
}

// ==================== ГЛАВНЫЙ КЛАСС ====================

class Program
{
    private static ModuleDefMD? module;
    private static readonly HashSet<TypeDef> processedTypes = new();
    private static readonly HashSet<TypeDef> typeStack = new();
    
    private static readonly Dictionary<string, NameMapping> GlobalNameMap = new();
    private static readonly HashSet<string> UsedCleanNames = new();
    
    private const int MAX_DEPTH = 50;
    private const int MAX_GENERIC_DEPTH = 20;
    
    // Профилировщик
    private static readonly Profiler profiler = new();
    
    // Кэш для скомпилированных regex
    private static readonly Dictionary<string, Regex> RegexCache = new();
    
    static void Main(string[] args)
    {
        var totalWatch = Stopwatch.StartNew();
        
        if (args.Length == 0)
        {
            Console.WriteLine("IL Code Extractor with Full Metadata");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("Использование: ILExtractor <сборка.dll> [папка_вывода]");
            return;
        }
        
        var assemblyPath = args[0];
        var outputDir = args.Length > 1 ? args[1] : "IL_Output";
        
        if (!File.Exists(assemblyPath))
        {
            Console.WriteLine($"Ошибка: Файл не найден: {assemblyPath}");
            return;
        }
        
        try
        {
            // Загрузка сборки
            profiler.Start("LoadAssembly");
            module = ModuleDefMD.Load(assemblyPath);
            profiler.Stop("LoadAssembly");
            
            Console.WriteLine($"Загружена сборка: {module.Name}");
            Console.WriteLine($"Типов: {module.Types.Count}");
            Console.WriteLine();
            
            Directory.CreateDirectory(outputDir);
            
            // ===== ПРОХОД 1: Сбор имён =====
            profiler.Start("Pass1_CollectNames");
            Console.WriteLine("Проход 1: Сбор имён...");
            
            int typeCount = 0;
            foreach (var type in module.Types)
            {
                profiler.Start("CollectNames_SingleType");
                CollectNames(type);
                profiler.Stop("CollectNames_SingleType");
                typeCount++;
            }
            
            profiler.Stop("Pass1_CollectNames");
            Console.WriteLine($"Собрано {GlobalNameMap.Count} имён для замены из {typeCount} типов");
            Console.WriteLine();
            
            // ===== ПРОХОД 2: Генерация IL =====
            profiler.Start("Pass2_GenerateIL");
            Console.WriteLine("Проход 2: Генерация IL...");
            
            profiler.Start("SaveAssemblyInfo");
            SaveAssemblyInfo(module, outputDir);
            profiler.Stop("SaveAssemblyInfo");
            
            profiler.Start("SaveUserStrings");
            SaveUserStrings(module, outputDir);
            profiler.Stop("SaveUserStrings");
            
            profiler.Start("SaveNameMappings");
            SaveNameMappings(outputDir);
            profiler.Stop("SaveNameMappings");
            
            int processedCount = 0;
            foreach (var type in module.Types)
            {
                if (type.Name == "<Module>") continue;
                if (type.IsNested) continue;
                
                profiler.Start("ProcessType_Single");
                ProcessType(type, outputDir);
                profiler.Stop("ProcessType_Single");
                
                processedCount++;
                if (processedCount % 50 == 0)
                {
                    Console.WriteLine($"  Обработано типов: {processedCount}");
                }
            }
            
            profiler.Stop("Pass2_GenerateIL");
            
            totalWatch.Stop();
            
            Console.WriteLine();
            Console.WriteLine($"Готово! IL-код сохранён в: {outputDir}");
            Console.WriteLine($"Словарь замен: {outputDir}/_NameMappings.txt");
            Console.WriteLine($"Общее время: {totalWatch.ElapsedMilliseconds} ms");
            
            // Выводим профилирование
            profiler.PrintSummary();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
    
    // ==================== ПРОХОД 1: СБОР ИМЁН ====================
    
    static void CollectNames(TypeDef type)
    {
        // Имя типа
        if (NeedsRenaming(type.Name))
        {
            RegisterName(
                GetTypeFullName(type),
                type.Name,
                GenerateCleanTypeName(type),
                ElementType.Type,
                GetTypeDescription(type),
                type.DeclaringType?.FullName
            );
        }
        
        // Поля
        foreach (var field in type.Fields)
        {
            if (NeedsRenaming(field.Name))
            {
                RegisterName(
                    $"{GetTypeFullName(type)}::{field.Name}",
                    field.Name,
                    GenerateCleanFieldName(field),
                    ElementType.Field,
                    GetFieldDescription(field.Name),
                    GetTypeFullName(type)
                );
            }
        }
        
        // Методы
        foreach (var method in type.Methods)
        {
            if (NeedsRenaming(method.Name))
            {
                RegisterName(
                    $"{GetTypeFullName(type)}::{method.Name}",
                    method.Name,
                    GenerateCleanMethodName(method),
                    ElementType.Method,
                    GetMethodDescription(method.Name),
                    GetTypeFullName(type)
                );
            }
            
            // Параметры — пропускаем для скорости, они редко нужны
            // Локальные переменные — пропускаем для скорости
        }
        
        // Свойства и события — только если имя плохое (редко)
        foreach (var prop in type.Properties)
        {
            if (NeedsRenaming(prop.Name))
            {
                RegisterName(
                    $"{GetTypeFullName(type)}::prop::{prop.Name}",
                    prop.Name,
                    GenerateCleanPropertyName(prop.Name),
                    ElementType.Property,
                    "Property",
                    GetTypeFullName(type)
                );
            }
        }
        
        // Вложенные типы (рекурсивно)
        foreach (var nested in type.NestedTypes)
        {
            CollectNames(nested);
        }
    }
    
    static string GetTypeFullName(TypeDef type)
    {
        if (type.DeclaringType != null)
        {
            return $"{GetTypeFullName(type.DeclaringType)}/{type.Name}";
        }
        return type.FullName;
    }
    
    static bool NeedsRenaming(string name)
    {
        if (string.IsNullOrEmpty(name)) return false;
        
        // Быстрая проверка — если нет < то точно не нужно
        if (!name.Contains('<') && !name.Contains("k__BackingField"))
            return false;
        
        return true;
    }
    
    static void RegisterName(string fullName, string shortName, string cleanName, 
                             ElementType elementType, string description, string? declaringType)
    {
        if (GlobalNameMap.ContainsKey(fullName)) return;
        
        var finalCleanName = cleanName;
        var counter = 2;
        while (UsedCleanNames.Contains($"{declaringType}::{finalCleanName}"))
        {
            finalCleanName = $"{cleanName}_{counter}";
            counter++;
        }
        
        UsedCleanNames.Add($"{declaringType}::{finalCleanName}");
        
        GlobalNameMap[fullName] = new NameMapping
        {
            OriginalFullName = fullName,
            OriginalShortName = shortName,
            CleanName = finalCleanName,
            ElementType = elementType,
            Description = description,
            DeclaringType = declaringType
        };
    }
    
    // ==================== ГЕНЕРАЦИЯ ЧИСТЫХ ИМЁН (с кэшированием regex) ====================
    
    static Regex GetOrCreateRegex(string pattern)
    {
        if (!RegexCache.TryGetValue(pattern, out var regex))
        {
            regex = new Regex(pattern, RegexOptions.Compiled);
            RegexCache[pattern] = regex;
        }
        return regex;
    }
    
    static string GenerateCleanTypeName(TypeDef type)
    {
        var name = type.Name.ToString();
        
        // Async state machine: <MethodName>d__N
        var asyncRegex = GetOrCreateRegex(@"<(\w+)>d__(\d+)");
        var asyncMatch = asyncRegex.Match(name);
        if (asyncMatch.Success)
        {
            return $"_stateMachine_{asyncMatch.Groups[1].Value}_{asyncMatch.Groups[2].Value}";
        }
        
        // Display class: <>c__DisplayClassN_N
        var displayRegex = GetOrCreateRegex(@"<>c__DisplayClass(\d+)_(\d+)");
        var displayMatch = displayRegex.Match(name);
        if (displayMatch.Success)
        {
            return $"_closure_{displayMatch.Groups[1].Value}_{displayMatch.Groups[2].Value}";
        }
        
        // Simple display class: <>c__DisplayClassN
        var displayRegex2 = GetOrCreateRegex(@"<>c__DisplayClass(\d+)");
        var displayMatch2 = displayRegex2.Match(name);
        if (displayMatch2.Success)
        {
            return $"_closure_{displayMatch2.Groups[1].Value}";
        }
        
        // Closure container: <>c
        if (name == "<>c")
        {
            return "_closureContainer";
        }
        
        // Anonymous type: <>f__AnonymousTypeN
        var anonRegex = GetOrCreateRegex(@"<>f__AnonymousType(\d+)");
        var anonMatch = anonRegex.Match(name);
        if (anonMatch.Success)
        {
            return $"_anonymousType_{anonMatch.Groups[1].Value}";
        }
        
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanFieldName(FieldDef field)
    {
        var name = field.Name.ToString();
        
        // Backing field: <PropertyName>k__BackingField
        var backingRegex = GetOrCreateRegex(@"<(\w+)>k__BackingField");
        var backingMatch = backingRegex.Match(name);
        if (backingMatch.Success)
        {
            var propName = backingMatch.Groups[1].Value;
            return $"_{char.ToLower(propName[0])}{propName.Substring(1)}";
        }
        
        // Async state
        if (name == "<>1__state") return "_asyncState";
        if (name.Contains("<>t__builder")) return "_asyncBuilder";
        if (name == "<>4__this") return "_capturedThis";
        
        // Awaiter: <>u__N
        var awaiterRegex = GetOrCreateRegex(@"<>u__(\d+)");
        var awaiterMatch = awaiterRegex.Match(name);
        if (awaiterMatch.Success)
        {
            return $"_awaiter{awaiterMatch.Groups[1].Value}";
        }
        
        // Spilled local: <>s__N
        var spilledRegex = GetOrCreateRegex(@"<>s__(\d+)");
        var spilledMatch = spilledRegex.Match(name);
        if (spilledMatch.Success)
        {
            return $"_temp{spilledMatch.Groups[1].Value}";
        }
        
        // Wrap: <>7__wrapN
        var wrapRegex = GetOrCreateRegex(@"<>7__wrap(\d+)");
        var wrapMatch = wrapRegex.Match(name);
        if (wrapMatch.Success)
        {
            return $"_wrapper{wrapMatch.Groups[1].Value}";
        }
        
        // Captured variable: <name>5__N
        var capturedRegex = GetOrCreateRegex(@"<(\w+)>5__(\d+)");
        var capturedMatch = capturedRegex.Match(name);
        if (capturedMatch.Success)
        {
            return $"_local_{capturedMatch.Groups[1].Value}_{capturedMatch.Groups[2].Value}";
        }
        
        // Parameter capture: <>3__paramName
        var paramRegex = GetOrCreateRegex(@"<>3__(\w+)");
        var paramMatch = paramRegex.Match(name);
        if (paramMatch.Success)
        {
            return $"_param_{paramMatch.Groups[1].Value}";
        }
        
        // Hoisted: <>8__N
        var hoistedRegex = GetOrCreateRegex(@"<>8__(\d+)");
        var hoistedMatch = hoistedRegex.Match(name);
        if (hoistedMatch.Success)
        {
            return $"_hoisted{hoistedMatch.Groups[1].Value}";
        }
        
        // Cached delegate: <>9__N_N
        var cachedRegex = GetOrCreateRegex(@"<>9__(\d+)_(\d+)");
        var cachedMatch = cachedRegex.Match(name);
        if (cachedMatch.Success)
        {
            return $"_cachedDelegate_{cachedMatch.Groups[1].Value}_{cachedMatch.Groups[2].Value}";
        }
        
        if (name == "<>9") return "_cachedDelegates";
        if (name == "<>2__current") return "_iteratorCurrent";
        if (name.Contains("<>l__initialThreadId")) return "_initialThreadId";
        
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanMethodName(MethodDef method)
    {
        var name = method.Name.ToString();
        
        // Lambda: <Method>b__N_N
        var lambdaRegex = GetOrCreateRegex(@"<(\w+)>b__(\d+)_(\d+)");
        var lambdaMatch = lambdaRegex.Match(name);
        if (lambdaMatch.Success)
        {
            return $"_lambda_{lambdaMatch.Groups[1].Value}_{lambdaMatch.Groups[2].Value}_{lambdaMatch.Groups[3].Value}";
        }
        
        // Lambda: <Method>b__N
        var lambdaRegex2 = GetOrCreateRegex(@"<(\w+)>b__(\d+)");
        var lambdaMatch2 = lambdaRegex2.Match(name);
        if (lambdaMatch2.Success)
        {
            return $"_lambda_{lambdaMatch2.Groups[1].Value}_{lambdaMatch2.Groups[2].Value}";
        }
        
        // Local function: <Method>g__LocalName|N_N
        var localFuncRegex = GetOrCreateRegex(@"<(\w+)>g__(\w+)\|(\d+)_(\d+)");
        var localFuncMatch = localFuncRegex.Match(name);
        if (localFuncMatch.Success)
        {
            return $"_localFunc_{localFuncMatch.Groups[1].Value}_{localFuncMatch.Groups[2].Value}";
        }
        
        // Constructor lambda: <.ctor>b__N_N
        var ctorLambdaRegex = GetOrCreateRegex(@"<\.(\w+)>b__(\d+)_(\d+)");
        var ctorLambdaMatch = ctorLambdaRegex.Match(name);
        if (ctorLambdaMatch.Success)
        {
            return $"_lambda_{ctorLambdaMatch.Groups[1].Value}_{ctorLambdaMatch.Groups[2].Value}_{ctorLambdaMatch.Groups[3].Value}";
        }
        
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanPropertyName(string name)
    {
        return CleanNameSimple(name);
    }
    
    static string CleanNameSimple(string name)
    {
        var result = name;
        
        // Простые замены без regex где возможно
        result = result.Replace("<>", "_");
        result = result.Replace("<", "_");
        result = result.Replace(">", "_");
        result = result.Replace("|", "_");
        
        // Убираем множественные подчёркивания
        while (result.Contains("__"))
        {
            result = result.Replace("__", "_");
        }
        
        result = result.Trim('_');
        
        if (string.IsNullOrEmpty(result)) result = "_unnamed";
        
        return result;
    }
    
    // ==================== ОПИСАНИЯ ====================
    
    static string GetTypeDescription(TypeDef type)
    {
        if (IsAsyncStateMachine(type)) return "Async state machine";
        if (IsIteratorStateMachine(type)) return "Iterator state machine";
        if (IsDisplayClass(type)) return "Closure/Display class";
        if (type.Name.Contains("<>c")) return "Closure container";
        if (type.Name.Contains("AnonymousType")) return "Anonymous type";
        return "Compiler-generated type";
    }
    
    static string GetFieldDescription(string name)
    {
        if (name == "<>1__state") return "Async state";
        if (name.Contains("<>t__builder")) return "Async builder";
        if (name == "<>4__this") return "Captured this";
        if (name.Contains("<>u__")) return "Awaiter";
        if (name.Contains("<>s__")) return "Temp local";
        if (name.Contains("<>7__wrap")) return "Wrapper";
        if (name.Contains("<>3__")) return "Captured param";
        if (name.Contains("k__BackingField")) return "Backing field";
        if (name.Contains("<>9")) return "Cached delegate";
        if (name.Contains("<>2__current")) return "Iterator current";
        if (name.Contains(">5__")) return "Captured local";
        return "Compiler-generated";
    }
    
    static string GetMethodDescription(string name)
    {
        if (name.Contains(">b__")) return "Lambda";
        if (name.Contains(">g__")) return "Local function";
        return "Compiler-generated";
    }
    
    // ==================== СОХРАНЕНИЕ СЛОВАРЯ ====================
    
    static void SaveNameMappings(string outDir)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine("// ==============================================================");
        sb.AppendLine("// NAME MAPPINGS — словарь замен имён");
        sb.AppendLine("// ==============================================================");
        sb.AppendLine();
        sb.AppendLine($"// Всего замен: {GlobalNameMap.Count}");
        sb.AppendLine();
        
        var grouped = GlobalNameMap.Values
            .OrderBy(m => m.ElementType)
            .ThenBy(m => m.OriginalShortName.Length)
            .ThenBy(m => m.OriginalShortName);
        
        ElementType? lastType = null;
        foreach (var mapping in grouped)
        {
            if (lastType != mapping.ElementType)
            {
                sb.AppendLine();
                sb.AppendLine($"// ===== {mapping.ElementType}S =====");
                lastType = mapping.ElementType;
            }
            
            sb.AppendLine($"{mapping.OriginalShortName} -> {mapping.CleanName} // {mapping.Description}");
        }
        
        File.WriteAllText(Path.Combine(outDir, "_NameMappings.txt"), sb.ToString());
    }
    
    // ==================== ПРИМЕНЕНИЕ ЗАМЕН (ОПТИМИЗИРОВАНО) ====================
    
    // Кэш отсортированных замен
    private static List<NameMapping>? _sortedMappings;
    
    static string ApplyReplacements(string text)
    {
        if (string.IsNullOrEmpty(text) || GlobalNameMap.Count == 0) 
            return text;
        
        profiler.Start("ApplyReplacements");
        
        // Ленивая инициализация отсортированного списка
        if (_sortedMappings == null)
        {
            profiler.Start("SortMappings");
            _sortedMappings = GlobalNameMap.Values
                .OrderByDescending(m => m.OriginalShortName.Length)
                .ToList();
            profiler.Stop("SortMappings");
        }
        
        var result = text;
        
        // Используем StringBuilder для множественных замен
        var sb = new StringBuilder(result);
        
        foreach (var mapping in _sortedMappings)
        {
            var original = mapping.OriginalShortName;
            var clean = mapping.CleanName;
            
            // Заменяем только в контексте (после :: или /)
            // Используем простые строковые замены вместо regex
            sb.Replace($"::{original}", $"::{clean}");
            sb.Replace($"/{original}", $"/{clean}");
            sb.Replace($" {original}", $" {clean}");
        }
        
        result = sb.ToString();
        
        profiler.Stop("ApplyReplacements");
        return result;
    }
    
    // ==================== ПРОХОД 2: ГЕНЕРАЦИЯ IL ====================
    
    static void ProcessType(TypeDef type, string outputDir)
    {
        if (processedTypes.Contains(type)) return;
        processedTypes.Add(type);
        
        var ns = string.IsNullOrEmpty(type.Namespace) 
            ? "_Global" 
            : type.Namespace.ToString().Replace('.', Path.DirectorySeparatorChar);
        var nsPath = Path.Combine(outputDir, ns);
        Directory.CreateDirectory(nsPath);
        
        var cleanTypeName = GetCleanTypeName(type);
        var typeName = SanitizeName(cleanTypeName);
        var filePath = Path.Combine(nsPath, $"{typeName}.il");
        
        profiler.Start("WriteType");
        var sw = new StringWriter();
        WriteType(sw, type, 0);
        var rawIL = sw.ToString();
        profiler.Stop("WriteType");
        
        // Применяем замены
        var ilCode = ApplyReplacements(rawIL);
        
        profiler.Start("WriteFile");
        File.WriteAllText(filePath, ilCode, Encoding.UTF8);
        profiler.Stop("WriteFile");
    }
    
    static string GetCleanTypeName(TypeDef type)
    {
        var fullName = GetTypeFullName(type);
        if (GlobalNameMap.TryGetValue(fullName, out var mapping))
        {
            return mapping.CleanName;
        }
        return type.Name;
    }
    
    // ==================== USER STRINGS ====================
    
    static void SaveUserStrings(ModuleDefMD mod, string outDir)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine("// ==============================================================");
        sb.AppendLine("// USER STRINGS HEAP — все строковые константы сборки");
        sb.AppendLine("// ==============================================================");
        sb.AppendLine();
        
        var usHeap = mod.USStream;
        if (usHeap != null)
        {
            uint offset = 1;
            int count = 0;
            
            while (offset < usHeap.StreamLength)
            {
                try
                {
                    var str = mod.ReadUserString(offset);
                    if (!string.IsNullOrEmpty(str))
                    {
                        sb.AppendLine($"// [0x{offset:X8}] Length: {str.Length}");
                        sb.AppendLine($"\"{EscapeString(str)}\"");
                        sb.AppendLine();
                        count++;
                    }
                    
                    uint len = (uint)str.Length * 2 + 1;
                    if (str.Length < 0x80)
                        offset += len + 1;
                    else if (str.Length < 0x4000)
                        offset += len + 2;
                    else
                        offset += len + 4;
                }
                catch
                {
                    offset++;
                }
                
                if (count > 100000) break;
            }
            
            sb.AppendLine($"// Всего строк: {count}");
        }
        
        File.WriteAllText(Path.Combine(outDir, "_UserStrings.txt"), sb.ToString());
    }
    
    // ==================== ASSEMBLY INFO ====================
    
    static void SaveAssemblyInfo(ModuleDefMD mod, string outDir)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine("// ==============================================================");
        sb.AppendLine("// ASSEMBLY MANIFEST");
        sb.AppendLine("// ==============================================================");
        sb.AppendLine();
        
        if (mod.Assembly != null)
        {
            sb.AppendLine($".assembly {mod.Assembly.Name}");
            sb.AppendLine("{");
            sb.AppendLine($"    .ver {mod.Assembly.Version.Major}:{mod.Assembly.Version.Minor}:{mod.Assembly.Version.Build}:{mod.Assembly.Version.Revision}");
            
            if (mod.Assembly.PublicKey != null && mod.Assembly.PublicKey.Data.Length > 0)
                sb.AppendLine($"    .publickey = ({BitConverter.ToString(mod.Assembly.PublicKey.Data).Replace("-", " ")})");
            
            if (!string.IsNullOrEmpty(mod.Assembly.Culture))
                sb.AppendLine($"    .culture \"{mod.Assembly.Culture}\"");
            
            foreach (var attr in mod.Assembly.CustomAttributes)
            {
                sb.AppendLine($"    .custom {FormatCustomAttribute(attr)}");
            }
            
            sb.AppendLine("}");
        }
        
        sb.AppendLine();
        sb.AppendLine($".module {mod.Name}");
        sb.AppendLine($"// MVID: {{{mod.Mvid}}}");
        sb.AppendLine($"// Runtime: {mod.RuntimeVersion}");
        sb.AppendLine($"// Kind: {mod.Kind}");
        sb.AppendLine();
        
        sb.AppendLine("// ==============================================================");
        sb.AppendLine("// ASSEMBLY REFERENCES");
        sb.AppendLine("// ==============================================================");
        sb.AppendLine();
        
        foreach (var asmRef in mod.GetAssemblyRefs())
        {
            sb.AppendLine($".assembly extern {asmRef.Name}");
            sb.AppendLine("{");
            sb.AppendLine($"    .ver {asmRef.Version.Major}:{asmRef.Version.Minor}:{asmRef.Version.Build}:{asmRef.Version.Revision}");
            
            if (asmRef.PublicKeyOrToken != null && asmRef.PublicKeyOrToken.Data.Length > 0)
                sb.AppendLine($"    .publickeytoken = ({BitConverter.ToString(asmRef.PublicKeyOrToken.Data).Replace("-", " ")})");
            
            sb.AppendLine("}");
            sb.AppendLine();
        }
        
        var result = ApplyReplacements(sb.ToString());
        File.WriteAllText(Path.Combine(outDir, "_AssemblyManifest.il"), result);
    }
    
    // ==================== TYPE ====================
    
    static void WriteType(TextWriter writer, TypeDef type, int depth)
    {
        if (depth > MAX_DEPTH)
        {
            writer.WriteLine($"// ПРЕДУПРЕЖДЕНИЕ: Превышена максимальная глубина ({MAX_DEPTH})");
            return;
        }
        
        if (typeStack.Contains(type))
        {
            writer.WriteLine($"// ЦИКЛ: {type.FullName}");
            return;
        }
        typeStack.Add(type);
        
        try
        {
            var indent = new string(' ', depth * 4);
            
            writer.WriteLine($"{indent}// ==============================================================");
            writer.WriteLine($"{indent}// TYPE: {type.FullName}");
            writer.WriteLine($"{indent}// Token: 0x{type.MDToken.Raw:X8}");
            
            string typeKind = GetTypeKind(type);
            if (typeKind != "TYPE")
            {
                writer.WriteLine($"{indent}// Kind: {typeKind}");
            }
            
            writer.WriteLine($"{indent}// ==============================================================");
            writer.WriteLine();
            
            writer.Write($"{indent}.class ");
            
            if (type.IsNested)
            {
                switch (type.Visibility)
                {
                    case TypeAttributes.NestedPublic: writer.Write("nested public "); break;
                    case TypeAttributes.NestedPrivate: writer.Write("nested private "); break;
                    case TypeAttributes.NestedFamily: writer.Write("nested family "); break;
                    case TypeAttributes.NestedAssembly: writer.Write("nested assembly "); break;
                    case TypeAttributes.NestedFamORAssem: writer.Write("nested famorassem "); break;
                    case TypeAttributes.NestedFamANDAssem: writer.Write("nested famandassem "); break;
                }
            }
            else
            {
                if (type.IsPublic) writer.Write("public ");
                else writer.Write("private ");
            }
            
            if (type.IsInterface) writer.Write("interface ");
            if (type.IsAbstract) writer.Write("abstract ");
            if (type.IsSealed) writer.Write("sealed ");
            if (type.IsAutoLayout) writer.Write("auto ");
            if (type.IsSequentialLayout) writer.Write("sequential ");
            if (type.IsExplicitLayout) writer.Write("explicit ");
            if (type.IsAnsiClass) writer.Write("ansi ");
            if (type.IsUnicodeClass) writer.Write("unicode ");
            if (type.IsBeforeFieldInit) writer.Write("beforefieldinit ");
            if (type.IsSerializable) writer.Write("serializable ");
            if (type.IsSpecialName) writer.Write("specialname ");
            if (type.IsRuntimeSpecialName) writer.Write("rtspecialname ");
            
            writer.Write(type.Name);
            
            if (type.HasGenericParameters)
            {
                writer.Write("<");
                for (int i = 0; i < type.GenericParameters.Count; i++)
                {
                    if (i > 0) writer.Write(", ");
                    var gp = type.GenericParameters[i];
                    WriteGenericParamConstraints(writer, gp);
                    writer.Write(gp.Name);
                }
                writer.Write(">");
            }
            
            writer.WriteLine();
            
            if (type.BaseType != null)
            {
                writer.WriteLine($"{indent}    extends {FormatTypeRef(type.BaseType, 0)}");
            }
            
            if (type.HasInterfaces)
            {
                writer.WriteLine($"{indent}    implements");
                for (int i = 0; i < type.Interfaces.Count; i++)
                {
                    var comma = i < type.Interfaces.Count - 1 ? "," : "";
                    writer.WriteLine($"{indent}        {FormatTypeRef(type.Interfaces[i].Interface, 0)}{comma}");
                }
            }
            
            writer.WriteLine($"{indent}{{");
            
            foreach (var attr in type.CustomAttributes)
            {
                writer.WriteLine($"{indent}    .custom {FormatCustomAttribute(attr)}");
            }
            
            if (type.HasCustomAttributes)
                writer.WriteLine();
            
            // Static constructor first
            var cctor = type.FindStaticConstructor();
            if (cctor != null)
            {
                writer.WriteLine($"{indent}    // ==== STATIC CONSTRUCTOR ====");
                writer.WriteLine();
                WriteMethod(writer, cctor, depth + 1);
            }
            
            if (type.HasFields)
            {
                writer.WriteLine($"{indent}    // ==== FIELDS ====");
                writer.WriteLine();
                foreach (var field in type.Fields)
                {
                    WriteField(writer, field, depth + 1);
                }
                writer.WriteLine();
            }
            
            if (type.HasProperties)
            {
                writer.WriteLine($"{indent}    // ==== PROPERTIES ====");
                writer.WriteLine();
                foreach (var prop in type.Properties)
                {
                    WriteProperty(writer, prop, depth + 1);
                }
                writer.WriteLine();
            }
            
            if (type.HasEvents)
            {
                writer.WriteLine($"{indent}    // ==== EVENTS ====");
                writer.WriteLine();
                foreach (var evt in type.Events)
                {
                    WriteEvent(writer, evt, depth + 1);
                }
                writer.WriteLine();
            }
            
            if (type.HasMethods)
            {
                writer.WriteLine($"{indent}    // ==== METHODS ====");
                writer.WriteLine();
                foreach (var method in type.Methods)
                {
                    if (method.IsStaticConstructor) continue;
                    WriteMethod(writer, method, depth + 1);
                }
            }
            
            if (type.HasNestedTypes)
            {
                writer.WriteLine($"{indent}    // ==== NESTED TYPES ====");
                writer.WriteLine();
                foreach (var nested in type.NestedTypes)
                {
                    WriteType(writer, nested, depth + 1);
                    writer.WriteLine();
                }
            }
            
            writer.WriteLine($"{indent}}} // end of class {type.Name}");
        }
        finally
        {
            typeStack.Remove(type);
        }
    }
    
    // ==================== HELPERS ====================
    
    static string GetTypeKind(TypeDef type)
    {
        if (type.IsInterface) return "INTERFACE";
        if (type.IsEnum) return "ENUM";
        if (type.IsValueType) return "STRUCT";
        if (type.IsDelegate) return "DELEGATE";
        if (IsAsyncStateMachine(type)) return "ASYNC STATE MACHINE";
        if (IsIteratorStateMachine(type)) return "ITERATOR STATE MACHINE";
        if (IsDisplayClass(type)) return "CLOSURE";
        return "TYPE";
    }
    
    static bool IsAsyncStateMachine(TypeDef type)
    {
        foreach (var iface in type.Interfaces)
        {
            if (iface.Interface.FullName == "System.Runtime.CompilerServices.IAsyncStateMachine")
                return true;
        }
        return type.Name.Contains("<") && type.Name.Contains(">d__");
    }
    
    static bool IsIteratorStateMachine(TypeDef type)
    {
        foreach (var iface in type.Interfaces)
        {
            var name = iface.Interface.FullName;
            if ((name.Contains("IEnumerator") || name.Contains("IEnumerable")) &&
                type.Name.Contains("<") && type.Name.Contains(">d__"))
                return true;
        }
        return false;
    }
    
    static bool IsDisplayClass(TypeDef type)
    {
        return type.Name.Contains("<>c__DisplayClass") || type.Name == "<>c";
    }
    
    // ==================== FIELD ====================
    
    static void WriteField(TextWriter writer, FieldDef field, int depth)
    {
        var indent = new string(' ', depth * 4);
        
        writer.Write($"{indent}.field ");
        
        if (field.IsPublic) writer.Write("public ");
        else if (field.IsPrivate) writer.Write("private ");
        else if (field.IsFamily) writer.Write("family ");
        else if (field.IsAssembly) writer.Write("assembly ");
        else if (field.IsFamilyOrAssembly) writer.Write("famorassem ");
        else if (field.IsFamilyAndAssembly) writer.Write("famandassem ");
        
        if (field.IsStatic) writer.Write("static ");
        if (field.IsInitOnly) writer.Write("initonly ");
        if (field.IsLiteral) writer.Write("literal ");
        if (field.IsNotSerialized) writer.Write("notserialized ");
        if (field.IsSpecialName) writer.Write("specialname ");
        if (field.IsRuntimeSpecialName) writer.Write("rtspecialname ");
        
        writer.Write($"{FormatTypeSig(field.FieldType, 0)} {field.Name}");
        
        if (field.HasConstant)
        {
            writer.Write($" = {FormatConstant(field.Constant.Value, field.FieldType)}");
        }
        
        if (field.HasFieldRVA)
        {
            writer.Write($" at D_{(uint)field.RVA:X8}");
        }
        
        writer.WriteLine();
        
        foreach (var attr in field.CustomAttributes)
        {
            writer.WriteLine($"{indent}    .custom {FormatCustomAttribute(attr)}");
        }
    }
    
    // ==================== PROPERTY ====================
    
    static void WriteProperty(TextWriter writer, PropertyDef prop, int depth)
    {
        var indent = new string(' ', depth * 4);
        
        writer.Write($"{indent}.property ");
        
        if (prop.IsSpecialName) writer.Write("specialname ");
        if (prop.IsRuntimeSpecialName) writer.Write("rtspecialname ");
        
        var propSig = prop.PropertySig;
        if (propSig != null && propSig.HasThis)
            writer.Write("instance ");
        
        writer.WriteLine($"{FormatTypeSig(propSig?.RetType, 0)} {prop.Name}()");
        writer.WriteLine($"{indent}{{");
        
        if (prop.GetMethod != null)
            writer.WriteLine($"{indent}    .get {FormatMethodRef(prop.GetMethod, 0)}");
        
        if (prop.SetMethod != null)
            writer.WriteLine($"{indent}    .set {FormatMethodRef(prop.SetMethod, 0)}");
        
        writer.WriteLine($"{indent}}}");
    }
    
    // ==================== EVENT ====================
    
    static void WriteEvent(TextWriter writer, EventDef evt, int depth)
    {
        var indent = new string(' ', depth * 4);
        
        writer.Write($"{indent}.event ");
        
        if (evt.IsSpecialName) writer.Write("specialname ");
        if (evt.IsRuntimeSpecialName) writer.Write("rtspecialname ");
        
        writer.WriteLine($"{FormatTypeRef(evt.EventType, 0)} {evt.Name}");
        writer.WriteLine($"{indent}{{");
        
        if (evt.AddMethod != null)
            writer.WriteLine($"{indent}    .addon {FormatMethodRef(evt.AddMethod, 0)}");
        
        if (evt.RemoveMethod != null)
            writer.WriteLine($"{indent}    .removeon {FormatMethodRef(evt.RemoveMethod, 0)}");
        
        if (evt.InvokeMethod != null)
            writer.WriteLine($"{indent}    .fire {FormatMethodRef(evt.InvokeMethod, 0)}");
        
        writer.WriteLine($"{indent}}}");
    }
    
    // ==================== METHOD ====================
    
    static void WriteMethod(TextWriter writer, MethodDef method, int depth)
    {
        var indent = new string(' ', depth * 4);
        
        writer.WriteLine($"{indent}// Token: 0x{method.MDToken.Raw:X8}");
        writer.WriteLine($"{indent}// RVA: 0x{(uint)method.RVA:X8}");
        writer.Write($"{indent}.method ");
        
        if (method.IsPublic) writer.Write("public ");
        else if (method.IsPrivate) writer.Write("private ");
        else if (method.IsFamily) writer.Write("family ");
        else if (method.IsAssembly) writer.Write("assembly ");
        else if (method.IsFamilyOrAssembly) writer.Write("famorassem ");
        else if (method.IsFamilyAndAssembly) writer.Write("famandassem ");
        
        if (method.IsStatic) writer.Write("static ");
        if (method.IsFinal) writer.Write("final ");
        if (method.IsVirtual) writer.Write("virtual ");
        if (method.IsAbstract) writer.Write("abstract ");
        if (method.IsHideBySig) writer.Write("hidebysig ");
        if (method.IsNewSlot) writer.Write("newslot ");
        if (method.IsSpecialName) writer.Write("specialname ");
        if (method.IsRuntimeSpecialName) writer.Write("rtspecialname ");
        
        var sig = method.MethodSig;
        if (sig != null)
        {
            if (sig.HasThis) writer.Write("instance ");
            if (sig.ExplicitThis) writer.Write("explicit ");
        }
        
        writer.WriteLine();
        writer.Write($"{indent}    {FormatTypeSig(method.ReturnType, 0)} ");
        writer.Write(method.Name);
        
        if (method.HasGenericParameters)
        {
            writer.Write("<");
            for (int i = 0; i < method.GenericParameters.Count; i++)
            {
                if (i > 0) writer.Write(", ");
                writer.Write(method.GenericParameters[i].Name);
            }
            writer.Write(">");
        }
        
        writer.Write("(");
        var parameters = method.Parameters.Where(p => !p.IsHiddenThisParameter).ToList();
        for (int i = 0; i < parameters.Count; i++)
        {
            if (i > 0) writer.Write(", ");
            var param = parameters[i];
            writer.Write($"{FormatTypeSig(param.Type, 0)} {param.Name}");
        }
        writer.Write(")");
        
        var implFlags = method.ImplAttributes;
        if ((implFlags & MethodImplAttributes.CodeTypeMask) == MethodImplAttributes.IL) writer.Write(" cil");
        if ((implFlags & MethodImplAttributes.ManagedMask) == MethodImplAttributes.Managed) writer.Write(" managed");
        
        writer.WriteLine();
        writer.WriteLine($"{indent}{{");
        
        if (method.HasBody && method.Body != null)
        {
            var body = method.Body;
            
            writer.WriteLine($"{indent}    .maxstack {body.MaxStack}");
            
            if (body.HasVariables)
            {
                writer.Write($"{indent}    .locals ");
                if (body.InitLocals) writer.Write("init ");
                writer.WriteLine("(");
                
                for (int i = 0; i < body.Variables.Count; i++)
                {
                    var local = body.Variables[i];
                    var comma = i < body.Variables.Count - 1 ? "," : "";
                    writer.WriteLine($"{indent}        [{i}] {FormatTypeSig(local.Type, 0)}{comma}");
                }
                
                writer.WriteLine($"{indent}    )");
            }
            
            if (module != null && method == module.EntryPoint)
            {
                writer.WriteLine($"{indent}    .entrypoint");
            }
            
            writer.WriteLine();
            
            foreach (var instr in body.Instructions)
            {
                var label = $"IL_{instr.Offset:X4}";
                var operand = FormatOperand(instr);
                writer.WriteLine($"{indent}    {label}: {instr.OpCode.Name,-12} {operand}");
            }
            
            if (body.HasExceptionHandlers)
            {
                writer.WriteLine();
                foreach (var eh in body.ExceptionHandlers)
                {
                    writer.WriteLine($"{indent}    .try IL_{eh.TryStart?.Offset:X4} to IL_{eh.TryEnd?.Offset:X4}");
                    
                    switch (eh.HandlerType)
                    {
                        case ExceptionHandlerType.Catch:
                            writer.WriteLine($"{indent}        catch {FormatTypeRef(eh.CatchType, 0)} handler IL_{eh.HandlerStart?.Offset:X4} to IL_{eh.HandlerEnd?.Offset:X4}");
                            break;
                        case ExceptionHandlerType.Finally:
                            writer.WriteLine($"{indent}        finally handler IL_{eh.HandlerStart?.Offset:X4} to IL_{eh.HandlerEnd?.Offset:X4}");
                            break;
                        case ExceptionHandlerType.Fault:
                            writer.WriteLine($"{indent}        fault handler IL_{eh.HandlerStart?.Offset:X4} to IL_{eh.HandlerEnd?.Offset:X4}");
                            break;
                        case ExceptionHandlerType.Filter:
                            writer.WriteLine($"{indent}        filter IL_{eh.FilterStart?.Offset:X4} handler IL_{eh.HandlerStart?.Offset:X4} to IL_{eh.HandlerEnd?.Offset:X4}");
                            break;
                    }
                }
            }
        }
        else
        {
            writer.WriteLine($"{indent}    // No method body");
        }
        
        writer.WriteLine($"{indent}}} // end of method {method.DeclaringType?.Name}::{method.Name}");
        writer.WriteLine();
    }
    
    // ==================== GENERIC CONSTRAINTS ====================
    
    static void WriteGenericParamConstraints(TextWriter writer, GenericParam gp)
    {
        var constraints = new List<string>();
        
        if (gp.HasReferenceTypeConstraint) constraints.Add("class");
        if (gp.HasNotNullableValueTypeConstraint) constraints.Add("valuetype");
        if (gp.HasDefaultConstructorConstraint) constraints.Add(".ctor");
        
        foreach (var gc in gp.GenericParamConstraints)
        {
            constraints.Add($"({FormatTypeRef(gc.Constraint, 0)})");
        }
        
        if (constraints.Count > 0)
        {
            writer.Write($"({string.Join(", ", constraints)}) ");
        }
    }
    
    // ==================== FORMATTING ====================
    
    static string FormatTypeSig(TypeSig? sig, int depth)
    {
        if (sig == null) return "void";
        if (depth > MAX_GENERIC_DEPTH) return sig.FullName;
        
        return sig switch
        {
            CorLibTypeSig corLib => corLib.TypeDefOrRef.Name,
            GenericInstSig genInst => FormatGenericInstSig(genInst, depth + 1),
            ByRefSig byRef => $"{FormatTypeSig(byRef.Next, depth + 1)}&",
            PtrSig ptr => $"{FormatTypeSig(ptr.Next, depth + 1)}*",
            SZArraySig szArray => $"{FormatTypeSig(szArray.Next, depth + 1)}[]",
            ArraySig array => FormatArraySig(array, depth + 1),
            GenericVar genVar => $"!{genVar.Number}",
            GenericMVar genMVar => $"!!{genMVar.Number}",
            PinnedSig pinned => $"{FormatTypeSig(pinned.Next, depth + 1)} pinned",
            CModReqdSig modReq => $"{FormatTypeSig(modReq.Next, depth + 1)} modreq({FormatTypeRef(modReq.Modifier, depth + 1)})",
            CModOptSig modOpt => $"{FormatTypeSig(modOpt.Next, depth + 1)} modopt({FormatTypeRef(modOpt.Modifier, depth + 1)})",
            ValueTypeSig valType => $"valuetype {valType.TypeDefOrRef?.FullName ?? "???"}",
            ClassSig classSig => $"class {classSig.TypeDefOrRef?.FullName ?? "???"}",
            FnPtrSig fnPtr => FormatFnPtrSig(fnPtr, depth + 1),
            TypeDefOrRefSig typeDefOrRef => typeDefOrRef.TypeDefOrRef?.FullName ?? "???",
            _ => sig.FullName
        };
    }
    
    static string FormatGenericInstSig(GenericInstSig genInst, int depth)
    {
        if (depth > MAX_GENERIC_DEPTH) return genInst.FullName;
        
        var sb = new StringBuilder();
        sb.Append(FormatTypeRef(genInst.GenericType?.TypeDefOrRef, depth));
        sb.Append("<");
        
        for (int i = 0; i < genInst.GenericArguments.Count; i++)
        {
            if (i > 0) sb.Append(", ");
            sb.Append(FormatTypeSig(genInst.GenericArguments[i], depth + 1));
        }
        
        sb.Append(">");
        return sb.ToString();
    }
    
    static string FormatArraySig(ArraySig array, int depth)
    {
        if (depth > MAX_GENERIC_DEPTH) return array.FullName;
        
        var sb = new StringBuilder();
        sb.Append(FormatTypeSig(array.Next, depth + 1));
        sb.Append("[");
        
        for (uint i = 0; i < array.Rank; i++)
        {
            if (i > 0) sb.Append(",");
        }
        
        sb.Append("]");
        return sb.ToString();
    }
    
    static string FormatFnPtrSig(FnPtrSig fnPtr, int depth)
    {
        if (depth > MAX_GENERIC_DEPTH) return "method ...";
        
        var sb = new StringBuilder();
        sb.Append("method ");
        
        var methodSig = fnPtr.MethodSig;
        if (methodSig.HasThis) sb.Append("instance ");
        
        sb.Append(FormatTypeSig(methodSig.RetType, depth + 1));
        sb.Append(" *(");
        
        for (int i = 0; i < methodSig.Params.Count; i++)
        {
            if (i > 0) sb.Append(", ");
            sb.Append(FormatTypeSig(methodSig.Params[i], depth + 1));
        }
        
        sb.Append(")");
        return sb.ToString();
    }
    
    static string FormatTypeRef(ITypeDefOrRef? type, int depth)
    {
        if (type == null) return "???";
        if (depth > MAX_GENERIC_DEPTH) return type.FullName;
        
        if (type is TypeSpec ts && ts.TypeSig != null)
        {
            return FormatTypeSig(ts.TypeSig, depth + 1);
        }
        
        return type.FullName;
    }
    
    static string FormatMethodRef(IMethod? method, int depth)
    {
        if (method == null) return "???";
        if (depth > MAX_GENERIC_DEPTH) return method.FullName;
        
        var sb = new StringBuilder();
        
        if (method.MethodSig?.HasThis == true)
            sb.Append("instance ");
        
        sb.Append($"{FormatTypeSig(method.MethodSig?.RetType, depth + 1)} ");
        sb.Append($"{FormatTypeRef(method.DeclaringType, depth + 1)}::{method.Name}");
        
        if (method is MethodSpec ms && ms.GenericInstMethodSig != null)
        {
            sb.Append("<");
            for (int i = 0; i < ms.GenericInstMethodSig.GenericArguments.Count; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(FormatTypeSig(ms.GenericInstMethodSig.GenericArguments[i], depth + 1));
            }
            sb.Append(">");
        }
        
        sb.Append("(");
        var paramTypes = method.MethodSig?.Params;
        if (paramTypes != null)
        {
            for (int i = 0; i < paramTypes.Count; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(FormatTypeSig(paramTypes[i], depth + 1));
            }
        }
        sb.Append(")");
        
        return sb.ToString();
    }
    
    static string FormatOperand(Instruction instr)
    {
        if (instr.Operand == null) return "";
        
        return instr.Operand switch
        {
            Instruction target => $"IL_{target.Offset:X4}",
            Instruction[] targets => "(" + string.Join(", ", targets.Select(t => $"IL_{t.Offset:X4}")) + ")",
            string s => $"\"{EscapeString(s)}\"",
            int i => i.ToString(),
            long l => l.ToString(),
            float f => $"{f:R}",
            double d => $"{d:R}",
            sbyte sb => sb.ToString(),
            byte b => b.ToString(),
            IField field => FormatFieldRef(field),
            IMethod method => FormatMethodRef(method, 0),
            ITypeDefOrRef type => FormatTypeRef(type, 0),
            Local local => $"V_{local.Index}",
            Parameter param => $"A_{param.Index}",
            MethodSig msig => FormatMethodSig(msig),
            _ => instr.Operand.ToString() ?? ""
        };
    }
    
    static string FormatFieldRef(IField? field)
    {
        if (field == null) return "???";
        return $"{FormatTypeSig(field.FieldSig?.Type, 0)} {FormatTypeRef(field.DeclaringType, 0)}::{field.Name}";
    }
    
    static string FormatMethodSig(MethodSig sig)
    {
        var sb = new StringBuilder();
        if (sig.HasThis) sb.Append("instance ");
        sb.Append(FormatTypeSig(sig.RetType, 0));
        sb.Append(" *(");
        
        for (int i = 0; i < sig.Params.Count; i++)
        {
            if (i > 0) sb.Append(", ");
            sb.Append(FormatTypeSig(sig.Params[i], 0));
        }
        
        sb.Append(")");
        return sb.ToString();
    }
    
    static string FormatCustomAttribute(CustomAttribute attr)
    {
        var sb = new StringBuilder();
        sb.Append($"instance void {attr.Constructor?.DeclaringType?.FullName ?? "???"}::.ctor(");
        
        if (attr.Constructor?.MethodSig?.Params != null)
        {
            for (int i = 0; i < attr.Constructor.MethodSig.Params.Count; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(FormatTypeSig(attr.Constructor.MethodSig.Params[i], 0));
            }
        }
        
        sb.Append(")");
        
        if (attr.HasConstructorArguments || attr.HasNamedArguments)
        {
            sb.Append(" = { ");
            
            var parts = new List<string>();
            
            foreach (var arg in attr.ConstructorArguments)
            {
                parts.Add(FormatCAArgument(arg, 0));
            }
            
            foreach (var arg in attr.NamedArguments)
            {
                var prefix = arg.IsField ? "field" : "property";
                parts.Add($"{prefix} {FormatTypeSig(arg.Type, 0)} {arg.Name} = {FormatCAArgument(arg.Argument, 0)}");
            }
            
            sb.Append(string.Join(", ", parts));
            sb.Append(" }");
        }
        
        return sb.ToString();
    }
    
    static string FormatCAArgument(CAArgument arg, int depth)
    {
        if (arg.Value == null) return "nullref";
        if (depth > MAX_GENERIC_DEPTH) return "...";
        
        return arg.Value switch
        {
            string s => $"\"{EscapeString(s)}\"",
            bool b => b ? "true" : "false",
            UTF8String u => $"\"{EscapeString(u.String)}\"",
            TypeSig t => $"typeof({FormatTypeSig(t, depth + 1)})",
            IList<CAArgument> list => "{" + string.Join(", ", list.Select(a => FormatCAArgument(a, depth + 1))) + "}",
            CAArgument nested => FormatCAArgument(nested, depth + 1),
            _ => arg.Value.ToString() ?? "null"
        };
    }
    
    static string FormatConstant(object? value, TypeSig? type)
    {
        if (value == null) return "nullref";
        
        return value switch
        {
            string s => $"\"{EscapeString(s)}\"",
            char c => $"char(0x{(int)c:X4})",
            bool b => b ? "bool(true)" : "bool(false)",
            float f => $"float32({f:R})",
            double d => $"float64({d:R})",
            sbyte sb => $"int8({sb})",
            byte b => $"uint8({b})",
            short sh => $"int16({sh})",
            ushort us => $"uint16({us})",
            int i => $"int32({i})",
            uint u => $"uint32({u})",
            long l => $"int64({l})",
            ulong ul => $"uint64({ul})",
            byte[] bytes => "(" + BitConverter.ToString(bytes).Replace("-", " ") + ")",
            _ => value.ToString() ?? "null"
        };
    }
    
    static string EscapeString(string s)
    {
        var sb = new StringBuilder(s.Length + 10);
        foreach (var c in s)
        {
            switch (c)
            {
                case '\\': sb.Append("\\\\"); break;
                case '"': sb.Append("\\\""); break;
                case '\n': sb.Append("\\n"); break;
                case '\r': sb.Append("\\r"); break;
                case '\t': sb.Append("\\t"); break;
                case '\0': sb.Append("\\0"); break;
                default:
                    if (c < 32 || c > 126)
                        sb.Append($"\\u{(int)c:X4}");
                    else
                        sb.Append(c);
                    break;
            }
        }
        return sb.ToString();
    }
    
    static string SanitizeName(string name)
    {
        var sb = new StringBuilder(name.Length);
        var invalid = Path.GetInvalidFileNameChars();
        
        foreach (var c in name)
        {
            if (Array.IndexOf(invalid, c) >= 0 || c == '<' || c == '>' || c == '`')
                sb.Append('_');
            else
                sb.Append(c);
        }
        
        return sb.ToString();
    }
}
