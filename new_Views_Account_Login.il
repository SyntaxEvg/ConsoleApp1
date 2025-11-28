using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ILExtractor;

// ==================== СТРУКТУРЫ ====================

enum ElementType { Type, Field, Method, Property, Event, Parameter, Local }

class NameMapping
{
    public string OriginalShortName { get; set; } = "";
    public string CleanName { get; set; } = "";
    public ElementType ElementType { get; set; }
    public string Description { get; set; } = "";
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
    }
}

// ==================== ГЛАВНЫЙ КЛАСС ====================

class Program
{
    private static ModuleDefMD? module;
    private static readonly HashSet<TypeDef> processedTypes = new();
    private static readonly HashSet<TypeDef> typeStack = new();
    
    // Словарь: короткое имя -> чистое имя (для быстрого поиска)
    private static readonly Dictionary<string, string> ShortNameMap = new();
    private static readonly Dictionary<string, NameMapping> GlobalNameMap = new();
    private static readonly HashSet<string> UsedCleanNames = new();
    
    private const int MAX_DEPTH = 50;
    private const int MAX_GENERIC_DEPTH = 20;
    
    private static readonly Profiler profiler = new();
    
    // Скомпилированный Regex для замены (будет создан после сбора имён)
    private static Regex? _replacementRegex;
    
    static void Main(string[] args)
    {
        var totalWatch = Stopwatch.StartNew();
        
        if (args.Length == 0)
        {
            Console.WriteLine("IL Code Extractor with Full Metadata");
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
            
            foreach (var type in module.Types)
            {
                CollectNames(type);
            }
            
            // Создаём единый Regex для всех замен
            profiler.Start("BuildRegex");
            BuildReplacementRegex();
            profiler.Stop("BuildRegex");
            
            profiler.Stop("Pass1_CollectNames");
            Console.WriteLine($"Собрано {ShortNameMap.Count} уникальных имён для замены");
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
            Console.WriteLine($"Общее время: {totalWatch.ElapsedMilliseconds} ms");
            
            profiler.PrintSummary();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
    
    // ==================== БЫСТРАЯ ЗАМЕНА ЧЕРЕЗ ОДИН REGEX ====================
    
    static void BuildReplacementRegex()
    {
        if (ShortNameMap.Count == 0)
        {
            _replacementRegex = null;
            return;
        }
        
        // Сортируем по длине (длинные первыми) и экранируем
        var patterns = ShortNameMap.Keys
            .OrderByDescending(k => k.Length)
            .Select(Regex.Escape)
            .ToList();
        
        // Создаём один большой regex: (pattern1|pattern2|pattern3|...)
        // С lookbehind для контекста (после :: или / или пробела)
        var combinedPattern = $@"(?<=::|/|\s)({string.Join("|", patterns)})(?=\s|::|/|\(|\)|,|$)";
        
        _replacementRegex = new Regex(combinedPattern, RegexOptions.Compiled);
    }
    
    static string ApplyReplacements(string text)
    {
        if (string.IsNullOrEmpty(text) || _replacementRegex == null)
            return text;
        
        profiler.Start("ApplyReplacements");
        
        var result = _replacementRegex.Replace(text, match =>
        {
            if (ShortNameMap.TryGetValue(match.Value, out var clean))
                return clean;
            return match.Value;
        });
        
        profiler.Stop("ApplyReplacements");
        return result;
    }
    
    // ==================== ПРОХОД 1: СБОР ИМЁН ====================
    
    static void CollectNames(TypeDef type)
    {
        // Тип
        if (NeedsRenaming(type.Name))
        {
            RegisterName(type.Name, GenerateCleanTypeName(type), ElementType.Type, GetTypeDescription(type));
        }
        
        // Поля
        foreach (var field in type.Fields)
        {
            if (NeedsRenaming(field.Name))
            {
                RegisterName(field.Name, GenerateCleanFieldName(field.Name), ElementType.Field, GetFieldDescription(field.Name));
            }
        }
        
        // Методы
        foreach (var method in type.Methods)
        {
            if (NeedsRenaming(method.Name))
            {
                RegisterName(method.Name, GenerateCleanMethodName(method.Name), ElementType.Method, GetMethodDescription(method.Name));
            }
        }
        
        // Вложенные типы
        foreach (var nested in type.NestedTypes)
        {
            CollectNames(nested);
        }
    }
    
    static bool NeedsRenaming(string name)
    {
        if (string.IsNullOrEmpty(name)) return false;
        return name.Contains('<') || name.Contains("k__BackingField");
    }
    
    static void RegisterName(string shortName, string cleanName, ElementType elementType, string description)
    {
        // Используем только короткие имена — они уникальны в контексте
        if (ShortNameMap.ContainsKey(shortName)) return;
        
        var finalCleanName = cleanName;
        var counter = 2;
        while (UsedCleanNames.Contains(finalCleanName))
        {
            finalCleanName = $"{cleanName}_{counter}";
            counter++;
        }
        
        UsedCleanNames.Add(finalCleanName);
        ShortNameMap[shortName] = finalCleanName;
        
        GlobalNameMap[shortName] = new NameMapping
        {
            OriginalShortName = shortName,
            CleanName = finalCleanName,
            ElementType = elementType,
            Description = description
        };
    }
    
    // ==================== ГЕНЕРАЦИЯ ЧИСТЫХ ИМЁН ====================
    
    static string GenerateCleanTypeName(TypeDef type)
    {
        var name = type.Name.ToString();
        
        // <MethodName>d__N
        var match = Regex.Match(name, @"<(\w+)>d__(\d+)");
        if (match.Success)
            return $"_sm_{match.Groups[1].Value}_{match.Groups[2].Value}";
        
        // <>c__DisplayClassN_N
        match = Regex.Match(name, @"<>c__DisplayClass(\d+)_(\d+)");
        if (match.Success)
            return $"_closure_{match.Groups[1].Value}_{match.Groups[2].Value}";
        
        // <>c__DisplayClassN
        match = Regex.Match(name, @"<>c__DisplayClass(\d+)");
        if (match.Success)
            return $"_closure_{match.Groups[1].Value}";
        
        if (name == "<>c") return "_cc";
        
        // <>f__AnonymousTypeN
        match = Regex.Match(name, @"<>f__AnonymousType(\d+)");
        if (match.Success)
            return $"_anon_{match.Groups[1].Value}";
        
        return CleanSimple(name);
    }
    
    static string GenerateCleanFieldName(string name)
    {
        // <Prop>k__BackingField
        var match = Regex.Match(name, @"<(\w+)>k__BackingField");
        if (match.Success)
        {
            var propName = match.Groups[1].Value;
            return $"_{char.ToLower(propName[0])}{propName.Substring(1)}";
        }
        
        if (name == "<>1__state") return "_state";
        if (name.Contains("<>t__builder")) return "_builder";
        if (name == "<>4__this") return "_this";
        
        // <>u__N
        match = Regex.Match(name, @"<>u__(\d+)");
        if (match.Success) return $"_aw{match.Groups[1].Value}";
        
        // <>s__N
        match = Regex.Match(name, @"<>s__(\d+)");
        if (match.Success) return $"_t{match.Groups[1].Value}";
        
        // <>7__wrapN
        match = Regex.Match(name, @"<>7__wrap(\d+)");
        if (match.Success) return $"_wr{match.Groups[1].Value}";
        
        // <name>5__N
        match = Regex.Match(name, @"<(\w+)>5__(\d+)");
        if (match.Success) return $"_l_{match.Groups[1].Value}_{match.Groups[2].Value}";
        
        // <>3__param
        match = Regex.Match(name, @"<>3__(\w+)");
        if (match.Success) return $"_p_{match.Groups[1].Value}";
        
        // <>8__N
        match = Regex.Match(name, @"<>8__(\d+)");
        if (match.Success) return $"_h{match.Groups[1].Value}";
        
        // <>9__N_N
        match = Regex.Match(name, @"<>9__(\d+)_(\d+)");
        if (match.Success) return $"_cd_{match.Groups[1].Value}_{match.Groups[2].Value}";
        
        // <>9
        if (name == "<>9") return "_cds";
        if (name == "<>2__current") return "_cur";
        if (name.Contains("<>l__initialThreadId")) return "_tid";
        
        return CleanSimple(name);
    }
    
    static string GenerateCleanMethodName(string name)
    {
        // <Method>b__N_N
        var match = Regex.Match(name, @"<(\w+)>b__(\d+)_(\d+)");
        if (match.Success)
            return $"_lm_{match.Groups[1].Value}_{match.Groups[2].Value}_{match.Groups[3].Value}";
        
        // <Method>b__N
        match = Regex.Match(name, @"<(\w+)>b__(\d+)");
        if (match.Success)
            return $"_lm_{match.Groups[1].Value}_{match.Groups[2].Value}";
        
        // <Method>g__Local|N_N
        match = Regex.Match(name, @"<(\w+)>g__(\w+)\|(\d+)_(\d+)");
        if (match.Success)
            return $"_lf_{match.Groups[1].Value}_{match.Groups[2].Value}";
        
        // <.ctor>b__N_N
        match = Regex.Match(name, @"<\.(\w+)>b__(\d+)_(\d+)");
        if (match.Success)
            return $"_lm_{match.Groups[1].Value}_{match.Groups[2].Value}_{match.Groups[3].Value}";
        
        return CleanSimple(name);
    }
    
    static string CleanSimple(string name)
    {
        var result = name
            .Replace("<>", "_")
            .Replace("<", "_")
            .Replace(">", "_")
            .Replace("|", "_");
        
        while (result.Contains("__"))
            result = result.Replace("__", "_");
        
        return result.Trim('_');
    }
    
    // ==================== ОПИСАНИЯ ====================
    
    static string GetTypeDescription(TypeDef type)
    {
        if (type.Interfaces.Any(i => i.Interface.FullName.Contains("IAsyncStateMachine")))
            return "Async SM";
        if (type.Name.Contains("DisplayClass")) return "Closure";
        if (type.Name == "<>c") return "Closure container";
        return "Compiler-gen";
    }
    
    static string GetFieldDescription(string name)
    {
        if (name == "<>1__state") return "Async state";
        if (name.Contains("<>t__builder")) return "Builder";
        if (name.Contains("<>u__")) return "Awaiter";
        if (name.Contains("<>s__")) return "Temp";
        if (name.Contains("k__BackingField")) return "Backing";
        return "Compiler-gen";
    }
    
    static string GetMethodDescription(string name)
    {
        if (name.Contains(">b__")) return "Lambda";
        if (name.Contains(">g__")) return "Local func";
        return "Compiler-gen";
    }
    
    // ==================== СОХРАНЕНИЕ ====================
    
    static void SaveNameMappings(string outDir)
    {
        var sb = new StringBuilder();
        sb.AppendLine("// NAME MAPPINGS");
        sb.AppendLine($"// Total: {GlobalNameMap.Count}");
        sb.AppendLine();
        
        foreach (var g in GlobalNameMap.Values.GroupBy(m => m.ElementType).OrderBy(g => g.Key))
        {
            sb.AppendLine($"// === {g.Key}S ===");
            foreach (var m in g.OrderBy(x => x.OriginalShortName))
            {
                sb.AppendLine($"{m.OriginalShortName} -> {m.CleanName} // {m.Description}");
            }
            sb.AppendLine();
        }
        
        File.WriteAllText(Path.Combine(outDir, "_NameMappings.txt"), sb.ToString());
    }
    
    static void SaveUserStrings(ModuleDefMD mod, string outDir)
    {
        var sb = new StringBuilder();
        sb.AppendLine("// USER STRINGS HEAP");
        sb.AppendLine();
        
        var usHeap = mod.USStream;
        if (usHeap == null)
        {
            sb.AppendLine("// Empty");
            File.WriteAllText(Path.Combine(outDir, "_UserStrings.txt"), sb.ToString());
            return;
        }
        
        uint offset = 1;
        int count = 0;
        
        while (offset < usHeap.StreamLength && count < 100000)
        {
            try
            {
                var str = mod.ReadUserString(offset);
                if (!string.IsNullOrEmpty(str))
                {
                    sb.AppendLine($"// [0x{offset:X8}] Len:{str.Length}");
                    sb.AppendLine($"\"{EscapeString(str)}\"");
                    sb.AppendLine();
                    count++;
                }
                
                uint len = (uint)str.Length * 2 + 1;
                offset += str.Length < 0x80 ? len + 1 : (str.Length < 0x4000 ? len + 2 : len + 4);
            }
            catch { offset++; }
        }
        
        sb.AppendLine($"// Total: {count}");
        File.WriteAllText(Path.Combine(outDir, "_UserStrings.txt"), sb.ToString());
    }
    
    static void SaveAssemblyInfo(ModuleDefMD mod, string outDir)
    {
        var sb = new StringBuilder();
        sb.AppendLine("// ASSEMBLY MANIFEST");
        sb.AppendLine();
        
        if (mod.Assembly != null)
        {
            sb.AppendLine($".assembly {mod.Assembly.Name}");
            sb.AppendLine("{");
            sb.AppendLine($"    .ver {mod.Assembly.Version}");
            sb.AppendLine("}");
        }
        
        sb.AppendLine();
        sb.AppendLine($".module {mod.Name}");
        sb.AppendLine($"// MVID: {mod.Mvid}");
        sb.AppendLine($"// Runtime: {mod.RuntimeVersion}");
        sb.AppendLine();
        
        sb.AppendLine("// ASSEMBLY REFS");
        foreach (var asmRef in mod.GetAssemblyRefs())
        {
            sb.AppendLine($".assembly extern {asmRef.Name} {{ .ver {asmRef.Version} }}");
        }
        
        File.WriteAllText(Path.Combine(outDir, "_AssemblyManifest.il"), sb.ToString());
    }
    
    // ==================== ПРОХОД 2: ГЕНЕРАЦИЯ ====================
    
    static void ProcessType(TypeDef type, string outputDir)
    {
        if (processedTypes.Contains(type)) return;
        processedTypes.Add(type);
        
        var ns = string.IsNullOrEmpty(type.Namespace) 
            ? "_Global" 
            : type.Namespace.ToString().Replace('.', Path.DirectorySeparatorChar);
        var nsPath = Path.Combine(outputDir, ns);
        Directory.CreateDirectory(nsPath);
        
        var cleanTypeName = ShortNameMap.TryGetValue(type.Name, out var clean) ? clean : type.Name;
        var typeName = SanitizeName(cleanTypeName);
        var filePath = Path.Combine(nsPath, $"{typeName}.il");
        
        profiler.Start("WriteType");
        var sw = new StringWriter();
        WriteType(sw, type, 0);
        var rawIL = sw.ToString();
        profiler.Stop("WriteType");
        
        var ilCode = ApplyReplacements(rawIL);
        
        profiler.Start("WriteFile");
        File.WriteAllText(filePath, ilCode, Encoding.UTF8);
        profiler.Stop("WriteFile");
    }
    
    // ==================== TYPE ====================
    
    static void WriteType(TextWriter writer, TypeDef type, int depth)
    {
        if (depth > MAX_DEPTH) return;
        
        if (typeStack.Contains(type))
        {
            writer.WriteLine($"// CYCLE: {type.FullName}");
            return;
        }
        typeStack.Add(type);
        
        try
        {
            var indent = new string(' ', depth * 4);
            
            writer.WriteLine($"{indent}// TYPE: {type.FullName}");
            writer.WriteLine($"{indent}// Token: 0x{type.MDToken.Raw:X8}");
            writer.WriteLine();
            
            writer.Write($"{indent}.class ");
            WriteTypeModifiers(writer, type);
            writer.Write(type.Name);
            WriteGenericParams(writer, type);
            writer.WriteLine();
            
            if (type.BaseType != null)
                writer.WriteLine($"{indent}    extends {FormatTypeRef(type.BaseType, 0)}");
            
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
            
            // Custom attributes
            foreach (var attr in type.CustomAttributes)
                writer.WriteLine($"{indent}    .custom {FormatCustomAttribute(attr)}");
            
            // Static constructor first
            var cctor = type.FindStaticConstructor();
            if (cctor != null)
            {
                writer.WriteLine($"{indent}    // === STATIC CTOR ===");
                WriteMethod(writer, cctor, depth + 1);
            }
            
            // Fields
            if (type.HasFields)
            {
                writer.WriteLine($"{indent}    // === FIELDS ===");
                foreach (var field in type.Fields)
                    WriteField(writer, field, depth + 1);
            }
            
            // Properties
            if (type.HasProperties)
            {
                writer.WriteLine($"{indent}    // === PROPERTIES ===");
                foreach (var prop in type.Properties)
                    WriteProperty(writer, prop, depth + 1);
            }
            
            // Events
            if (type.HasEvents)
            {
                writer.WriteLine($"{indent}    // === EVENTS ===");
                foreach (var evt in type.Events)
                    WriteEvent(writer, evt, depth + 1);
            }
            
            // Methods
            if (type.HasMethods)
            {
                writer.WriteLine($"{indent}    // === METHODS ===");
                foreach (var method in type.Methods)
                {
                    if (!method.IsStaticConstructor)
                        WriteMethod(writer, method, depth + 1);
                }
            }
            
            // Nested types
            if (type.HasNestedTypes)
            {
                writer.WriteLine($"{indent}    // === NESTED ===");
                foreach (var nested in type.NestedTypes)
                {
                    WriteType(writer, nested, depth + 1);
                    writer.WriteLine();
                }
            }
            
            writer.WriteLine($"{indent}}} // {type.Name}");
        }
        finally
        {
            typeStack.Remove(type);
        }
    }
    
    static void WriteTypeModifiers(TextWriter writer, TypeDef type)
    {
        if (type.IsNested)
        {
            writer.Write(type.Visibility switch
            {
                TypeAttributes.NestedPublic => "nested public ",
                TypeAttributes.NestedPrivate => "nested private ",
                TypeAttributes.NestedFamily => "nested family ",
                TypeAttributes.NestedAssembly => "nested assembly ",
                TypeAttributes.NestedFamORAssem => "nested famorassem ",
                TypeAttributes.NestedFamANDAssem => "nested famandassem ",
                _ => ""
            });
        }
        else
        {
            writer.Write(type.IsPublic ? "public " : "private ");
        }
        
        if (type.IsInterface) writer.Write("interface ");
        if (type.IsAbstract) writer.Write("abstract ");
        if (type.IsSealed) writer.Write("sealed ");
        if (type.IsAutoLayout) writer.Write("auto ");
        if (type.IsSequentialLayout) writer.Write("sequential ");
        if (type.IsAnsiClass) writer.Write("ansi ");
        if (type.IsBeforeFieldInit) writer.Write("beforefieldinit ");
    }
    
    static void WriteGenericParams(TextWriter writer, TypeDef type)
    {
        if (!type.HasGenericParameters) return;
        
        writer.Write("<");
        for (int i = 0; i < type.GenericParameters.Count; i++)
        {
            if (i > 0) writer.Write(", ");
            writer.Write(type.GenericParameters[i].Name);
        }
        writer.Write(">");
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
        
        if (field.IsStatic) writer.Write("static ");
        if (field.IsInitOnly) writer.Write("initonly ");
        if (field.IsLiteral) writer.Write("literal ");
        
        writer.Write($"{FormatTypeSig(field.FieldType, 0)} {field.Name}");
        
        if (field.HasConstant)
            writer.Write($" = {FormatConstant(field.Constant.Value)}");
        
        writer.WriteLine();
    }
    
    // ==================== PROPERTY ====================
    
    static void WriteProperty(TextWriter writer, PropertyDef prop, int depth)
    {
        var indent = new string(' ', depth * 4);
        var propSig = prop.PropertySig;
        
        writer.Write($"{indent}.property ");
        if (propSig?.HasThis == true) writer.Write("instance ");
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
        
        writer.WriteLine($"{indent}.event {FormatTypeRef(evt.EventType, 0)} {evt.Name}");
        writer.WriteLine($"{indent}{{");
        
        if (evt.AddMethod != null)
            writer.WriteLine($"{indent}    .addon {FormatMethodRef(evt.AddMethod, 0)}");
        if (evt.RemoveMethod != null)
            writer.WriteLine($"{indent}    .removeon {FormatMethodRef(evt.RemoveMethod, 0)}");
        
        writer.WriteLine($"{indent}}}");
    }
    
    // ==================== METHOD ====================
    
    static void WriteMethod(TextWriter writer, MethodDef method, int depth)
    {
        var indent = new string(' ', depth * 4);
        
        writer.WriteLine($"{indent}// 0x{method.MDToken.Raw:X8} RVA:0x{(uint)method.RVA:X8}");
        writer.Write($"{indent}.method ");
        
        // Access
        if (method.IsPublic) writer.Write("public ");
        else if (method.IsPrivate) writer.Write("private ");
        else if (method.IsFamily) writer.Write("family ");
        else if (method.IsAssembly) writer.Write("assembly ");
        
        // Modifiers
        if (method.IsStatic) writer.Write("static ");
        if (method.IsFinal) writer.Write("final ");
        if (method.IsVirtual) writer.Write("virtual ");
        if (method.IsAbstract) writer.Write("abstract ");
        if (method.IsHideBySig) writer.Write("hidebysig ");
        if (method.IsSpecialName) writer.Write("specialname ");
        if (method.IsRuntimeSpecialName) writer.Write("rtspecialname ");
        
        var sig = method.MethodSig;
        if (sig?.HasThis == true) writer.Write("instance ");
        
        writer.WriteLine();
        writer.Write($"{indent}    {FormatTypeSig(method.ReturnType, 0)} {method.Name}");
        
        // Generic params
        if (method.HasGenericParameters)
        {
            writer.Write("<");
            writer.Write(string.Join(", ", method.GenericParameters.Select(g => g.Name)));
            writer.Write(">");
        }
        
        // Parameters
        writer.Write("(");
        var ps = method.Parameters.Where(p => !p.IsHiddenThisParameter).ToList();
        writer.Write(string.Join(", ", ps.Select(p => $"{FormatTypeSig(p.Type, 0)} {p.Name}")));
        writer.Write(") cil managed");
        
        writer.WriteLine();
        writer.WriteLine($"{indent}{{");
        
        if (method.HasBody && method.Body != null)
        {
            var body = method.Body;
            writer.WriteLine($"{indent}    .maxstack {body.MaxStack}");
            
            // Locals
            if (body.HasVariables)
            {
                writer.Write($"{indent}    .locals ");
                if (body.InitLocals) writer.Write("init ");
                writer.Write("(");
                writer.Write(string.Join(", ", body.Variables.Select((v, i) => $"[{i}] {FormatTypeSig(v.Type, 0)}")));
                writer.WriteLine(")");
            }
            
            if (module != null && method == module.EntryPoint)
                writer.WriteLine($"{indent}    .entrypoint");
            
            writer.WriteLine();
            
            // Instructions
            foreach (var instr in body.Instructions)
            {
                writer.WriteLine($"{indent}    IL_{instr.Offset:X4}: {instr.OpCode.Name,-10} {FormatOperand(instr)}");
            }
            
            // Exception handlers
            if (body.HasExceptionHandlers)
            {
                writer.WriteLine();
                foreach (var eh in body.ExceptionHandlers)
                {
                    writer.WriteLine($"{indent}    .try IL_{eh.TryStart?.Offset:X4} to IL_{eh.TryEnd?.Offset:X4}");
                    var handlerType = eh.HandlerType switch
                    {
                        ExceptionHandlerType.Catch => $"catch {FormatTypeRef(eh.CatchType, 0)}",
                        ExceptionHandlerType.Finally => "finally",
                        ExceptionHandlerType.Fault => "fault",
                        ExceptionHandlerType.Filter => $"filter IL_{eh.FilterStart?.Offset:X4}",
                        _ => "?"
                    };
                    writer.WriteLine($"{indent}        {handlerType} handler IL_{eh.HandlerStart?.Offset:X4} to IL_{eh.HandlerEnd?.Offset:X4}");
                }
            }
        }
        
        writer.WriteLine($"{indent}}} // {method.Name}");
        writer.WriteLine();
    }
    
    // ==================== FORMATTING ====================
    
    static string FormatTypeSig(TypeSig? sig, int depth)
    {
        if (sig == null) return "void";
        if (depth > MAX_GENERIC_DEPTH) return sig.FullName;
        
        return sig switch
        {
            CorLibTypeSig c => c.TypeDefOrRef.Name,
            GenericInstSig g => $"{FormatTypeRef(g.GenericType?.TypeDefOrRef, depth)}<{string.Join(", ", g.GenericArguments.Select(a => FormatTypeSig(a, depth + 1)))}>",
            ByRefSig b => $"{FormatTypeSig(b.Next, depth + 1)}&",
            PtrSig p => $"{FormatTypeSig(p.Next, depth + 1)}*",
            SZArraySig a => $"{FormatTypeSig(a.Next, depth + 1)}[]",
            ArraySig ar => $"{FormatTypeSig(ar.Next, depth + 1)}[{new string(',', (int)ar.Rank - 1)}]",
            GenericVar gv => $"!{gv.Number}",
            GenericMVar gm => $"!!{gm.Number}",
            ValueTypeSig v => $"valuetype {v.TypeDefOrRef?.FullName}",
            ClassSig cl => $"class {cl.TypeDefOrRef?.FullName}",
            _ => sig.FullName
        };
    }
    
    static string FormatTypeRef(ITypeDefOrRef? type, int depth)
    {
        if (type == null) return "???";
        if (depth > MAX_GENERIC_DEPTH) return type.FullName;
        
        if (type is TypeSpec ts && ts.TypeSig != null)
            return FormatTypeSig(ts.TypeSig, depth + 1);
        
        return type.FullName;
    }
    
    static string FormatMethodRef(IMethod? method, int depth)
    {
        if (method == null) return "???";
        
        var sb = new StringBuilder();
        if (method.MethodSig?.HasThis == true) sb.Append("instance ");
        sb.Append(FormatTypeSig(method.MethodSig?.RetType, depth + 1));
        sb.Append($" {FormatTypeRef(method.DeclaringType, depth + 1)}::{method.Name}");
        
        if (method is MethodSpec ms && ms.GenericInstMethodSig != null)
        {
            sb.Append("<");
            sb.Append(string.Join(", ", ms.GenericInstMethodSig.GenericArguments.Select(a => FormatTypeSig(a, depth + 1))));
            sb.Append(">");
        }
        
        sb.Append("(");
        if (method.MethodSig?.Params != null)
            sb.Append(string.Join(", ", method.MethodSig.Params.Select(p => FormatTypeSig(p, depth + 1))));
        sb.Append(")");
        
        return sb.ToString();
    }
    
    static string FormatOperand(Instruction instr)
    {
        if (instr.Operand == null) return "";
        
        return instr.Operand switch
        {
            Instruction t => $"IL_{t.Offset:X4}",
            Instruction[] ts => $"({string.Join(", ", ts.Select(t => $"IL_{t.Offset:X4}"))})",
            string s => $"\"{EscapeString(s)}\"",
            int i => i.ToString(),
            long l => l.ToString(),
            float f => $"{f:R}",
            double d => $"{d:R}",
            sbyte sb => sb.ToString(),
            byte b => b.ToString(),
            IField fld => $"{FormatTypeSig(fld.FieldSig?.Type, 0)} {FormatTypeRef(fld.DeclaringType, 0)}::{fld.Name}",
            IMethod m => FormatMethodRef(m, 0),
            ITypeDefOrRef t => FormatTypeRef(t, 0),
            Local loc => $"V_{loc.Index}",
            Parameter p => $"A_{p.Index}",
            _ => instr.Operand.ToString() ?? ""
        };
    }
    
    static string FormatCustomAttribute(CustomAttribute attr)
    {
        var sb = new StringBuilder();
        sb.Append($"instance void {attr.Constructor?.DeclaringType?.FullName}::.ctor(");
        if (attr.Constructor?.MethodSig?.Params != null)
            sb.Append(string.Join(", ", attr.Constructor.MethodSig.Params.Select(p => FormatTypeSig(p, 0))));
        sb.Append(")");
        
        if (attr.HasConstructorArguments || attr.HasNamedArguments)
        {
            sb.Append(" = { ");
            var parts = attr.ConstructorArguments.Select(a => FormatCAArg(a))
                .Concat(attr.NamedArguments.Select(a => $"{(a.IsField ? "field" : "property")} {a.Name} = {FormatCAArg(a.Argument)}"));
            sb.Append(string.Join(", ", parts));
            sb.Append(" }");
        }
        
        return sb.ToString();
    }
    
    static string FormatCAArg(CAArgument arg)
    {
        if (arg.Value == null) return "null";
        return arg.Value switch
        {
            string s => $"\"{EscapeString(s)}\"",
            bool b => b.ToString().ToLower(),
            IList<CAArgument> list => $"{{{string.Join(", ", list.Select(FormatCAArg))}}}",
            _ => arg.Value.ToString() ?? "null"
        };
    }
    
    static string FormatConstant(object? value)
    {
        if (value == null) return "null";
        return value switch
        {
            string s => $"\"{EscapeString(s)}\"",
            bool b => b.ToString().ToLower(),
            float f => $"float32({f:R})",
            double d => $"float64({d:R})",
            _ => value.ToString() ?? "null"
        };
    }
    
    static string EscapeString(string s)
    {
        var sb = new StringBuilder(s.Length + 10);
        foreach (var c in s)
        {
            sb.Append(c switch
            {
                '\\' => "\\\\",
                '"' => "\\\"",
                '\n' => "\\n",
                '\r' => "\\r",
                '\t' => "\\t",
                '\0' => "\\0",
                _ when c < 32 || c > 126 => $"\\u{(int)c:X4}",
                _ => c.ToString()
            });
        }
        return sb.ToString();
    }
    
    static string SanitizeName(string name)
    {
        var sb = new StringBuilder(name.Length);
        var invalid = Path.GetInvalidFileNameChars();
        
        foreach (var c in name)
        {
            sb.Append(Array.IndexOf(invalid, c) >= 0 || c == '<' || c == '>' || c == '`' ? '_' : c);
        }
        
        return sb.ToString();
    }
}
