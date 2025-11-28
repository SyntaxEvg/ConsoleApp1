using dnlib.DotNet;
using dnlib.DotNet.Emit;
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

// ==================== ГЛАВНЫЙ КЛАСС ====================

class Program
{
    private static ModuleDefMD? module;
    private static readonly HashSet<TypeDef> processedTypes = new();
    private static readonly HashSet<TypeDef> typeStack = new();
    
    // Глобальный словарь замен
    private static readonly Dictionary<string, NameMapping> GlobalNameMap = new();
    private static readonly HashSet<string> UsedCleanNames = new();
    
    private const int MAX_DEPTH = 50;
    private const int MAX_GENERIC_DEPTH = 20;
    
    static void Main(string[] args)
    {
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
            module = ModuleDefMD.Load(assemblyPath);
            
            Console.WriteLine($"Загружена сборка: {module.Name}");
            Console.WriteLine($"Типов: {module.Types.Count}");
            Console.WriteLine();
            
            Directory.CreateDirectory(outputDir);
            
            // ===== ПРОХОД 1: Сбор имён =====
            Console.WriteLine("Проход 1: Сбор имён...");
            foreach (var type in module.Types)
            {
                CollectNames(type);
            }
            Console.WriteLine($"Собрано {GlobalNameMap.Count} имён для замены");
            Console.WriteLine();
            
            // ===== ПРОХОД 2: Генерация IL =====
            Console.WriteLine("Проход 2: Генерация IL...");
            
            SaveAssemblyInfo(module, outputDir);
            SaveUserStrings(module, outputDir);
            SaveNameMappings(outputDir);
            
            foreach (var type in module.Types)
            {
                if (type.Name == "<Module>") continue;
                if (type.IsNested) continue;
                
                ProcessType(type, outputDir);
            }
            
            Console.WriteLine();
            Console.WriteLine($"Готово! IL-код сохранён в: {outputDir}");
            Console.WriteLine($"Словарь замен: {outputDir}/_NameMappings.txt");
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
            
            // Параметры
            foreach (var param in method.Parameters)
            {
                if (!string.IsNullOrEmpty(param.Name) && NeedsRenaming(param.Name))
                {
                    RegisterName(
                        $"{GetTypeFullName(type)}::{method.Name}::param::{param.Name}",
                        param.Name,
                        GenerateCleanParamName(param.Name),
                        ElementType.Parameter,
                        "Parameter",
                        $"{GetTypeFullName(type)}::{method.Name}"
                    );
                }
            }
            
            // Локальные переменные
            if (method.HasBody && method.Body.HasVariables)
            {
                foreach (var local in method.Body.Variables)
                {
                    if (!string.IsNullOrEmpty(local.Name) && NeedsRenaming(local.Name))
                    {
                        RegisterName(
                            $"{GetTypeFullName(type)}::{method.Name}::local::{local.Name}",
                            local.Name,
                            GenerateCleanLocalName(local.Name),
                            ElementType.Local,
                            "Local variable",
                            $"{GetTypeFullName(type)}::{method.Name}"
                        );
                    }
                }
            }
        }
        
        // Свойства
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
        
        // События
        foreach (var evt in type.Events)
        {
            if (NeedsRenaming(evt.Name))
            {
                RegisterName(
                    $"{GetTypeFullName(type)}::event::{evt.Name}",
                    evt.Name,
                    GenerateCleanEventName(evt.Name),
                    ElementType.Event,
                    "Event",
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
        
        // Проверяем наличие "плохих" символов и паттернов
        return name.Contains('<') || 
               name.Contains('>') || 
               name.Contains('|') ||
               name.Contains("k__BackingField") ||
               name.Contains("__");
    }
    
    static void RegisterName(string fullName, string shortName, string cleanName, 
                             ElementType elementType, string description, string? declaringType)
    {
        if (GlobalNameMap.ContainsKey(fullName)) return;
        
        // Проверяем коллизии
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
    
    // ==================== ГЕНЕРАЦИЯ ЧИСТЫХ ИМЁН ====================
    
    static string GenerateCleanTypeName(TypeDef type)
    {
        var name = type.Name.ToString();
        
        // Async state machine: <MethodName>d__N
        var asyncMatch = Regex.Match(name, @"<(\w+)>d__(\d+)");
        if (asyncMatch.Success)
        {
            return $"_stateMachine_{asyncMatch.Groups[1].Value}_{asyncMatch.Groups[2].Value}";
        }
        
        // Display class: <>c__DisplayClassN_N
        var displayMatch = Regex.Match(name, @"<>c__DisplayClass(\d+)_(\d+)");
        if (displayMatch.Success)
        {
            return $"_closure_{displayMatch.Groups[1].Value}_{displayMatch.Groups[2].Value}";
        }
        
        // Simple display class: <>c__DisplayClassN
        var displayMatch2 = Regex.Match(name, @"<>c__DisplayClass(\d+)");
        if (displayMatch2.Success)
        {
            return $"_closure_{displayMatch2.Groups[1].Value}";
        }
        
        // Closure container: <>c
        if (name == "<>c")
        {
            return "_closureContainer";
        }
        
        // Iterator: <MethodName>d__N (same as async)
        
        // Anonymous type: <>f__AnonymousTypeN
        var anonMatch = Regex.Match(name, @"<>f__AnonymousType(\d+)");
        if (anonMatch.Success)
        {
            return $"_anonymousType_{anonMatch.Groups[1].Value}";
        }
        
        // Local function class: <<Method>g__Local|N_N>d
        var localFuncMatch = Regex.Match(name, @"<<(\w+)>g__(\w+)\|(\d+)_(\d+)>d");
        if (localFuncMatch.Success)
        {
            return $"_localFuncStateMachine_{localFuncMatch.Groups[1].Value}_{localFuncMatch.Groups[2].Value}";
        }
        
        // Fallback: remove bad chars
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanFieldName(FieldDef field)
    {
        var name = field.Name.ToString();
        
        // Backing field: <PropertyName>k__BackingField
        var backingMatch = Regex.Match(name, @"<(\w+)>k__BackingField");
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
        var awaiterMatch = Regex.Match(name, @"<>u__(\d+)");
        if (awaiterMatch.Success)
        {
            return $"_awaiter{awaiterMatch.Groups[1].Value}";
        }
        
        // Spilled local: <>s__N
        var spilledMatch = Regex.Match(name, @"<>s__(\d+)");
        if (spilledMatch.Success)
        {
            return $"_temp{spilledMatch.Groups[1].Value}";
        }
        
        // Wrap: <>7__wrapN
        var wrapMatch = Regex.Match(name, @"<>7__wrap(\d+)");
        if (wrapMatch.Success)
        {
            return $"_wrapper{wrapMatch.Groups[1].Value}";
        }
        
        // Captured variable: <name>5__N
        var capturedMatch = Regex.Match(name, @"<(\w+)>5__(\d+)");
        if (capturedMatch.Success)
        {
            return $"_local_{capturedMatch.Groups[1].Value}_{capturedMatch.Groups[2].Value}";
        }
        
        // Parameter capture: <>3__paramName
        var paramMatch = Regex.Match(name, @"<>3__(\w+)");
        if (paramMatch.Success)
        {
            return $"_param_{paramMatch.Groups[1].Value}";
        }
        
        // Hoisted: <>8__N
        var hoistedMatch = Regex.Match(name, @"<>8__(\d+)");
        if (hoistedMatch.Success)
        {
            return $"_hoisted{hoistedMatch.Groups[1].Value}";
        }
        
        // Cached delegate: <>9__N_N
        var cachedMatch = Regex.Match(name, @"<>9__(\d+)_(\d+)");
        if (cachedMatch.Success)
        {
            return $"_cachedDelegate_{cachedMatch.Groups[1].Value}_{cachedMatch.Groups[2].Value}";
        }
        
        // Simple <>9
        if (name == "<>9") return "_cachedDelegates";
        
        // Iterator current: <>2__current
        if (name == "<>2__current") return "_iteratorCurrent";
        
        // Iterator thread id: <>l__initialThreadId
        if (name.Contains("<>l__initialThreadId")) return "_initialThreadId";
        
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanMethodName(MethodDef method)
    {
        var name = method.Name.ToString();
        
        // Lambda: <Method>b__N or <Method>b__N_N
        var lambdaMatch = Regex.Match(name, @"<(\w+)>b__(\d+)_(\d+)");
        if (lambdaMatch.Success)
        {
            return $"_lambda_{lambdaMatch.Groups[1].Value}_{lambdaMatch.Groups[2].Value}_{lambdaMatch.Groups[3].Value}";
        }
        
        var lambdaMatch2 = Regex.Match(name, @"<(\w+)>b__(\d+)");
        if (lambdaMatch2.Success)
        {
            return $"_lambda_{lambdaMatch2.Groups[1].Value}_{lambdaMatch2.Groups[2].Value}";
        }
        
        // Local function: <Method>g__LocalName|N_N
        var localFuncMatch = Regex.Match(name, @"<(\w+)>g__(\w+)\|(\d+)_(\d+)");
        if (localFuncMatch.Success)
        {
            return $"_localFunc_{localFuncMatch.Groups[1].Value}_{localFuncMatch.Groups[2].Value}";
        }
        
        // Constructor lambda: <.ctor>b__N_N
        var ctorLambdaMatch = Regex.Match(name, @"<\.(\w+)>b__(\d+)_(\d+)");
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
    
    static string GenerateCleanEventName(string name)
    {
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanParamName(string name)
    {
        return CleanNameSimple(name);
    }
    
    static string GenerateCleanLocalName(string name)
    {
        // CS$<>8__localsN
        var csLocalMatch = Regex.Match(name, @"CS\$<>8__locals(\d+)");
        if (csLocalMatch.Success)
        {
            return $"_csLocals{csLocalMatch.Groups[1].Value}";
        }
        
        // <name>5__N
        var localMatch = Regex.Match(name, @"<(\w+)>5__(\d+)");
        if (localMatch.Success)
        {
            return $"_local_{localMatch.Groups[1].Value}_{localMatch.Groups[2].Value}";
        }
        
        return CleanNameSimple(name);
    }
    
    static string CleanNameSimple(string name)
    {
        // Удаляем/заменяем плохие символы
        var result = name;
        result = Regex.Replace(result, @"<(\w+)>", "_$1_");
        result = result.Replace("<>", "_");
        result = result.Replace("<", "_");
        result = result.Replace(">", "_");
        result = result.Replace("|", "_");
        result = Regex.Replace(result, @"_{2,}", "_");
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
        if (name == "<>1__state") return "Async state: -1=not started, 0+=awaiting, -2=completed";
        if (name.Contains("<>t__builder")) return "Async method builder";
        if (name == "<>4__this") return "Captured 'this' reference";
        if (name.Contains("<>u__")) return "Awaiter for async operation";
        if (name.Contains("<>s__")) return "Spilled/temporary local";
        if (name.Contains("<>7__wrap")) return "Wrapper for using/foreach";
        if (name.Contains("<>3__")) return "Captured parameter";
        if (name.Contains("k__BackingField")) return "Auto-property backing field";
        if (name.Contains("<>9")) return "Cached delegate instance";
        if (name.Contains("<>2__current")) return "Iterator current value";
        if (name.Contains("<>l__initialThreadId")) return "Iterator initial thread ID";
        if (name.Contains("<>8__")) return "Hoisted local";
        if (name.Contains(">5__")) return "Captured local variable";
        return "Compiler-generated field";
    }
    
    static string GetMethodDescription(string name)
    {
        if (name.Contains(">b__")) return "Lambda expression";
        if (name.Contains(">g__")) return "Local function";
        return "Compiler-generated method";
    }
    
    // ==================== СОХРАНЕНИЕ СЛОВАРЯ ====================
    
    static void SaveNameMappings(string outDir)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine("// ==============================================================");
        sb.AppendLine("// NAME MAPPINGS — словарь замен имён");
        sb.AppendLine("// ==============================================================");
        sb.AppendLine();
        sb.AppendLine("// Формат: OriginalName -> CleanName // Description");
        sb.AppendLine();
        
        // Группируем по типу элемента
        var grouped = GlobalNameMap.Values
            .OrderBy(m => m.ElementType)
            .ThenBy(m => m.DeclaringType)
            .ThenBy(m => m.OriginalShortName);
        
        ElementType? lastType = null;
        foreach (var mapping in grouped)
        {
            if (lastType != mapping.ElementType)
            {
                sb.AppendLine();
                sb.AppendLine($"// ===== {mapping.ElementType}S =====");
                sb.AppendLine();
                lastType = mapping.ElementType;
            }
            
            sb.AppendLine($"{mapping.OriginalShortName} -> {mapping.CleanName}");
            sb.AppendLine($"    // {mapping.Description}");
            if (mapping.DeclaringType != null)
            {
                sb.AppendLine($"    // In: {mapping.DeclaringType}");
            }
            sb.AppendLine();
        }
        
        sb.AppendLine($"// Всего замен: {GlobalNameMap.Count}");
        
        File.WriteAllText(Path.Combine(outDir, "_NameMappings.txt"), sb.ToString());
    }
    
    // ==================== ПРИМЕНЕНИЕ ЗАМЕН ====================
    
    /// <summary>
    /// Получить чистое имя для типа (короткое имя)
    /// </summary>
    static string GetCleanTypeName(TypeDef type)
    {
        var fullName = GetTypeFullName(type);
        if (GlobalNameMap.TryGetValue(fullName, out var mapping))
        {
            return mapping.CleanName;
        }
        return type.Name;
    }
    
    /// <summary>
    /// Получить чистое имя для поля
    /// </summary>
    static string GetCleanFieldName(FieldDef field)
    {
        var key = $"{GetTypeFullName(field.DeclaringType)}::{field.Name}";
        if (GlobalNameMap.TryGetValue(key, out var mapping))
        {
            return mapping.CleanName;
        }
        return field.Name;
    }
    
    /// <summary>
    /// Получить чистое имя для метода
    /// </summary>
    static string GetCleanMethodName(MethodDef method)
    {
        var key = $"{GetTypeFullName(method.DeclaringType)}::{method.Name}";
        if (GlobalNameMap.TryGetValue(key, out var mapping))
        {
            return mapping.CleanName;
        }
        return method.Name;
    }
    
    /// <summary>
    /// Применить замены к строке (для ссылок в IL)
    /// </summary>
    static string ApplyReplacements(string text)
    {
        if (string.IsNullOrEmpty(text)) return text;
        
        var result = text;
        
        // Сортируем по длине (длинные первыми) чтобы избежать частичных замен
        var sortedMappings = GlobalNameMap.Values
            .OrderByDescending(m => m.OriginalShortName.Length)
            .ToList();
        
        foreach (var mapping in sortedMappings)
        {
            // Заменяем с учётом границ слов (после :: или / или в начале)
            result = result.Replace($"::{mapping.OriginalShortName}", $"::{mapping.CleanName}");
            result = result.Replace($"/{mapping.OriginalShortName}", $"/{mapping.CleanName}");
            
            // Для типов в начале строки или после пробела
            if (mapping.ElementType == ElementType.Type)
            {
                result = Regex.Replace(result, 
                    $@"(\s|^){Regex.Escape(mapping.OriginalShortName)}(\s|/|::|$)", 
                    $"$1{mapping.CleanName}$2");
            }
        }
        
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
        
        var typeName = SanitizeName(GetCleanTypeName(type));
        var filePath = Path.Combine(nsPath, $"{typeName}.il");
        
        var sw = new StringWriter();
        WriteType(sw, type, 0);
        
        // Применяем замены ко всему файлу
        var ilCode = ApplyReplacements(sw.ToString());
        
        File.WriteAllText(filePath, ilCode, Encoding.UTF8);
        
        Console.WriteLine($"Обработан: {type.FullName} -> {typeName}.il");
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
        else
        {
            sb.AppendLine("// User Strings heap не найден");
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
            var cleanTypeName = GetCleanTypeName(type);
            
            writer.WriteLine($"{indent}// ==============================================================");
            writer.WriteLine($"{indent}// TYPE: {type.FullName}");
            if (type.Name != cleanTypeName)
            {
                writer.WriteLine($"{indent}// RENAMED TO: {cleanTypeName}");
            }
            writer.WriteLine($"{indent}// Token: 0x{type.MDToken.Raw:X8}");
            
            string typeKind = GetTypeKind(type);
            if (typeKind != "TYPE")
            {
                writer.WriteLine($"{indent}// Kind: {typeKind}");
            }
            
            if (IsAsyncStateMachine(type))
            {
                writer.WriteLine($"{indent}// NOTE: Async state machine. MoveNext() содержит логику async метода.");
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
            
            // Используем оригинальное имя в IL (замена применится позже)
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
            
            if (type.ClassLayout != null)
            {
                writer.WriteLine($"{indent}    .pack {type.ClassLayout.PackingSize}");
                writer.WriteLine($"{indent}    .size {type.ClassLayout.ClassSize}");
                writer.WriteLine();
            }
            
            // Static constructor first
            var cctor = type.FindStaticConstructor();
            if (cctor != null)
            {
                writer.WriteLine($"{indent}    // ==== STATIC CONSTRUCTOR (field initializers) ====");
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
        if (IsDisplayClass(type)) return "CLOSURE/DISPLAY CLASS";
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
        var cleanName = GetCleanFieldName(field);
        
        // Комментарий с информацией о поле
        if (field.Name != cleanName)
        {
            writer.WriteLine($"{indent}// Original: {field.Name}");
            writer.WriteLine($"{indent}// {GetFieldDescription(field.Name)}");
        }
        
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
        
        if (field.FieldOffset.HasValue)
        {
            writer.Write($"[{field.FieldOffset.Value}] ");
        }
        
        writer.Write($"{FormatTypeSig(field.FieldType, 0)} {field.Name}");
        
        if (field.HasConstant)
        {
            writer.Write($" = {FormatConstant(field.Constant.Value, field.FieldType)}");
        }
        
        if (field.HasFieldRVA)
        {
            writer.Write($" at D_{(uint)field.RVA:X8}");
            
            var initValue = field.InitialValue;
            if (initValue != null && initValue.Length > 0)
            {
                writer.WriteLine();
                writer.Write($"{indent}    // Initial data ({initValue.Length} bytes): ");
                if (initValue.Length <= 64)
                {
                    writer.Write(BitConverter.ToString(initValue).Replace("-", " "));
                }
                else
                {
                    writer.Write(BitConverter.ToString(initValue, 0, 64).Replace("-", " "));
                    writer.Write($" ... ({initValue.Length - 64} more bytes)");
                }
            }
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
        
        foreach (var attr in prop.CustomAttributes)
        {
            writer.WriteLine($"{indent}    .custom {FormatCustomAttribute(attr)}");
        }
        
        if (prop.GetMethod != null)
            writer.WriteLine($"{indent}    .get {FormatMethodRef(prop.GetMethod, 0)}");
        
        if (prop.SetMethod != null)
            writer.WriteLine($"{indent}    .set {FormatMethodRef(prop.SetMethod, 0)}");
        
        foreach (var other in prop.OtherMethods)
        {
            writer.WriteLine($"{indent}    .other {FormatMethodRef(other, 0)}");
        }
        
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
        
        foreach (var attr in evt.CustomAttributes)
        {
            writer.WriteLine($"{indent}    .custom {FormatCustomAttribute(attr)}");
        }
        
        if (evt.AddMethod != null)
            writer.WriteLine($"{indent}    .addon {FormatMethodRef(evt.AddMethod, 0)}");
        
        if (evt.RemoveMethod != null)
            writer.WriteLine($"{indent}    .removeon {FormatMethodRef(evt.RemoveMethod, 0)}");
        
        if (evt.InvokeMethod != null)
            writer.WriteLine($"{indent}    .fire {FormatMethodRef(evt.InvokeMethod, 0)}");
        
        foreach (var other in evt.OtherMethods)
        {
            writer.WriteLine($"{indent}    .other {FormatMethodRef(other, 0)}");
        }
        
        writer.WriteLine($"{indent}}}");
    }
    
    // ==================== METHOD ====================
    
    static void WriteMethod(TextWriter writer, MethodDef method, int depth)
    {
        var indent = new string(' ', depth * 4);
        var cleanName = GetCleanMethodName(method);
        
        if (method.Name != cleanName)
        {
            writer.WriteLine($"{indent}// Original: {method.Name}");
            writer.WriteLine($"{indent}// {GetMethodDescription(method.Name)}");
        }
        
        if (method.Name == "MoveNext" && IsAsyncStateMachine(method.DeclaringType))
        {
            writer.WriteLine($"{indent}// *** ASYNC METHOD BODY ***");
            writer.WriteLine($"{indent}// switch(_asyncState) определяет точку возобновления после await.");
        }
        
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
        if (method.IsPinvokeImpl) writer.Write("pinvokeimpl ");
        if (method.IsUnmanagedExport) writer.Write("unmanagedexp ");
        
        var sig = method.MethodSig;
        if (sig != null)
        {
            if (sig.HasThis) writer.Write("instance ");
            if (sig.ExplicitThis) writer.Write("explicit ");
            
            switch (sig.CallingConvention & CallingConvention.Mask)
            {
                case CallingConvention.VarArg: writer.Write("vararg "); break;
                case CallingConvention.NativeVarArg: writer.Write("unmanaged vararg "); break;
            }
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
                var gp = method.GenericParameters[i];
                WriteGenericParamConstraints(writer, gp);
                writer.Write(gp.Name);
            }
            writer.Write(">");
        }
        
        writer.Write("(");
        var parameters = method.Parameters.Where(p => !p.IsHiddenThisParameter).ToList();
        for (int i = 0; i < parameters.Count; i++)
        {
            if (i > 0) writer.Write(", ");
            var param = parameters[i];
            
            if (param.ParamDef != null)
            {
                if (param.ParamDef.IsIn) writer.Write("[in] ");
                if (param.ParamDef.IsOut) writer.Write("[out] ");
                if (param.ParamDef.IsOptional) writer.Write("[opt] ");
            }
            
            writer.Write($"{FormatTypeSig(param.Type, 0)} {param.Name}");
        }
        writer.Write(")");
        
        var implFlags = method.ImplAttributes;
        
        if ((implFlags & MethodImplAttributes.CodeTypeMask) == MethodImplAttributes.IL) writer.Write(" cil");
        if ((implFlags & MethodImplAttributes.CodeTypeMask) == MethodImplAttributes.Native) writer.Write(" native");
        if ((implFlags & MethodImplAttributes.CodeTypeMask) == MethodImplAttributes.Runtime) writer.Write(" runtime");
        if ((implFlags & MethodImplAttributes.ManagedMask) == MethodImplAttributes.Managed) writer.Write(" managed");
        if ((implFlags & MethodImplAttributes.ManagedMask) == MethodImplAttributes.Unmanaged) writer.Write(" unmanaged");
        if ((implFlags & MethodImplAttributes.ForwardRef) != 0) writer.Write(" forwardref");
        if ((implFlags & MethodImplAttributes.PreserveSig) != 0) writer.Write(" preservesig");
        if ((implFlags & MethodImplAttributes.InternalCall) != 0) writer.Write(" internalcall");
        if ((implFlags & MethodImplAttributes.Synchronized) != 0) writer.Write(" synchronized");
        if ((implFlags & MethodImplAttributes.NoInlining) != 0) writer.Write(" noinlining");
        if ((implFlags & MethodImplAttributes.NoOptimization) != 0) writer.Write(" nooptimization");
        if ((implFlags & MethodImplAttributes.AggressiveInlining) != 0) writer.Write(" aggressiveinlining");
        
        writer.WriteLine();
        writer.WriteLine($"{indent}{{");
        
        foreach (var attr in method.CustomAttributes)
        {
            writer.WriteLine($"{indent}    .custom {FormatCustomAttribute(attr)}");
        }
        
        foreach (var param in method.ParamDefs)
        {
            if (param.HasCustomAttributes || param.HasConstant)
            {
                writer.WriteLine($"{indent}    .param [{param.Sequence}]");
                foreach (var attr in param.CustomAttributes)
                {
                    writer.WriteLine($"{indent}        .custom {FormatCustomAttribute(attr)}");
                }
                if (param.HasConstant)
                {
                    writer.WriteLine($"{indent}        = {FormatConstant(param.Constant.Value, null)}");
                }
            }
        }
        
        foreach (var ovr in method.Overrides)
        {
            writer.WriteLine($"{indent}    .override {FormatMethodRef(ovr.MethodDeclaration, 0)}");
        }
        
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
                    var name = string.IsNullOrEmpty(local.Name) ? "" : $" {local.Name}";
                    writer.WriteLine($"{indent}        [{i}] {FormatTypeSig(local.Type, 0)}{name}{comma}");
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
                
                string comment = GetInstructionComment(instr);
                
                if (!string.IsNullOrEmpty(comment))
                {
                    writer.WriteLine($"{indent}    {label}: {instr.OpCode.Name,-12} {operand,-60} // {comment}");
                }
                else
                {
                    writer.WriteLine($"{indent}    {label}: {instr.OpCode.Name,-12} {operand}");
                }
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
    
    // ==================== INSTRUCTION COMMENTS ====================
    
    static string GetInstructionComment(Instruction instr)
    {
        if (instr.Operand is IField field)
        {
            var desc = GetFieldDescription(field.Name);
            if (desc != "Compiler-generated field") return desc;
        }
        
        if (instr.Operand is IMethod method)
        {
            var methodName = method.Name;
            
            if (methodName == "GetAwaiter") return "начало await";
            if (methodName == "get_IsCompleted") return "проверка завершения await";
            if (methodName == "GetResult") return "получение результата await";
            if (methodName == "AwaitUnsafeOnCompleted" || methodName == "AwaitOnCompleted") return "регистрация continuation";
            if (methodName == "SetResult") return "завершение async метода";
            if (methodName == "SetException") return "исключение в async методе";
            if (methodName == "WriteLiteral") return "вывод HTML";
            if (methodName == "Write") return "вывод значения";
            if (methodName == "MoveNext") return "следующий шаг итератора/async";
        }
        
        return "";
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
        
        if (depth > MAX_GENERIC_DEPTH)
        {
            return $"/* TOO DEEP */ {sig.FullName}";
        }
        
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
        if (depth > MAX_GENERIC_DEPTH)
        {
            return $"/* TOO DEEP */ {genInst.FullName}";
        }
        
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
        if (depth > MAX_GENERIC_DEPTH)
        {
            return $"/* TOO DEEP */ {array.FullName}";
        }
        
        var sb = new StringBuilder();
        sb.Append(FormatTypeSig(array.Next, depth + 1));
        sb.Append("[");
        
        for (uint i = 0; i < array.Rank; i++)
        {
            if (i > 0) sb.Append(",");
            
            if (i < (uint)array.LowerBounds.Count || i < (uint)array.Sizes.Count)
            {
                int lower = i < (uint)array.LowerBounds.Count ? array.LowerBounds[(int)i] : 0;
                uint size = i < (uint)array.Sizes.Count ? array.Sizes[(int)i] : 0;
                
                if (lower != 0 || size != 0)
                {
                    sb.Append(lower);
                    sb.Append("...");
                    if (size != 0)
                        sb.Append(lower + (int)size - 1);
                }
            }
        }
        
        sb.Append("]");
        return sb.ToString();
    }
    
    static string FormatFnPtrSig(FnPtrSig fnPtr, int depth)
    {
        if (depth > MAX_GENERIC_DEPTH)
        {
            return "/* TOO DEEP */ method ...";
        }
        
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
        
        if (depth > MAX_GENERIC_DEPTH)
        {
            return $"/* TOO DEEP */ {type.FullName}";
        }
        
        if (type is TypeSpec ts && ts.TypeSig != null)
        {
            return FormatTypeSig(ts.TypeSig, depth + 1);
        }
        
        return type.FullName;
    }
    
    static string FormatMethodRef(IMethod? method, int depth)
    {
        if (method == null) return "???";
        
        if (depth > MAX_GENERIC_DEPTH)
        {
            return $"/* TOO DEEP */ {method.FullName}";
        }
        
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
        
        if (depth > MAX_GENERIC_DEPTH)
        {
            return "/* TOO DEEP */";
        }
        
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
        var sb = new StringBuilder();
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
        var invalid = Path.GetInvalidFileNameChars();
        foreach (var c in invalid)
            name = name.Replace(c, '_');
        
        name = name.Replace('<', '_').Replace('>', '_').Replace('`', '_');
        
        return name;
    }
}
