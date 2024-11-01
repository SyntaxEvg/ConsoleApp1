using System;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;
using Serilog;
using Serilog.Events;
using Microsoft.Extensions.Configuration;
using copyFile;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Net;
using System.Linq;
using System.IO.Pipes;
using copyFile.Extensions;
using System.Threading.Tasks;
using AngleSharp.Dom;


class Program
{
    public static List<Replacement> Replacements = new List<Replacement>();
    /// <summary>
    /// сообщает статус из конфига о поддержке замены
    /// </summary>
    public static bool IsReplacements;
    private static ParserHtml parserHtml;
    private static string inputFolder;
    private static string outputFolder;
    public const string invalidChars = "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýþÿ";
    private static readonly Regex UnicodeEscapeRegex = new Regex(@"\\u00[0-9A-Za-z]{2}", RegexOptions.Compiled);
    static Dictionary<string, string> htmlEntities;
    static List<SearchTextBySelector> searchTextBySelector;
    private static string[] priorityGroups;
    private static Dictionary<string, string[]> extensionMapping;
    private static string[] priorityExtensions;
    /// <summary>
    /// Означает что документ был найден и дополнительный поиск и открытие больше не требуется. разработ для поиска по таблицам 
    /// </summary>
    public static bool isSeacrhComplited =false;
    internal static List<Replacement> ReplacementsInner =new();

    static void DecodeUnicodeEscapes(ref string? encodedText)
    {
        StringBuilder resultBuilder = new StringBuilder(encodedText);
        MatchCollection matchess = UnicodeEscapeRegex.Matches(encodedText);
        // Проходим по совпадениям в обратном порядке, чтобы индексы оставались верными
        for (int i = matchess.Count - 1; i >= 0; i--)
        {
            Match match = matchess[i];
            //Console.WriteLine($"Найдено: {match.Value} на позиции {match.Index}");
            string a = System.Text.RegularExpressions.Regex.Unescape(match.Value);
            byte[] b = Encoding.GetEncoding("UTF-8").GetBytes(a);
            string c = Encoding.UTF8.GetString(b);
            //Console.WriteLine(c);
            byte[] d = Encoding.GetEncoding(1252).GetBytes(c);
            string t = Encoding.GetEncoding(1251).GetString(d);
            resultBuilder.Remove(match.Index, match.Length);
            resultBuilder.Insert(match.Index, t);
        }
        encodedText = resultBuilder.ToString();
    }

    static void ReplaceHtmlEntities(ref string? input)
    {
       var inputs = Regex.Replace(input, "&[a-zA-Z]+;", match =>
        {
            string entity = match.Value;
            return htmlEntities.ContainsKey(entity) ? htmlEntities[entity] : entity;
        });
        input = inputs;
    }
    static void DecodeHtmlEntities(ref string input)
    {
        var inputs = Regex.Replace(input, @"&#(\d+);", match =>
        {
            int number = int.Parse(match.Groups[1].Value);
            return ((char)number).ToString();
        });
        input = inputs;
    }
    //static string HtmlDecode(string input)
    //{
    //    //string encodedString = "&#1046;&#1091;&#1088;&#1085;&#1072;&#1083; &#1040;&#1058;&#1055;";
    //    return WebUtility.HtmlDecode(input);
    //}
    //static string Convert1252_1251(string input, Encoding encoding)
    //{
    //    Encoding utf8 = Encoding.UTF8;

    //    return new string(input.Select(c =>
    //    {
    //        if (c >= '\u0080' && c <= '\u00FF')
    //        {
    //            byte[] bytes = new byte[] { (byte)c };
    //            string converted = encoding.GetString(bytes);
    //            return utf8.GetString(encoding.GetBytes(converted))[0];
    //        }
    //        return c;
    //    }).ToArray());

    //}


    //static bool ContainsInvalidCharacters(string text)
    //{
    //    return text.Any(c => invalidChars.Contains(c));
    //}
    //public static string DecodeCyrillic(string text)
    //{
    //    string restoredText = text;
    //    string[] cyrillicParts = Regex.Split(text, @"[a-zA-Z0-9\s]+");
    //    foreach (string part in cyrillicParts)
    //    {
    //        if (!string.IsNullOrEmpty(part))
    //        {
    //            byte[] bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(part);
    //            string decodedPart = Encoding.GetEncoding("windows-1251").GetString(bytes);
    //            restoredText = restoredText.Replace(part, decodedPart);
    //        }
    //    }
    //    return restoredText;
    //}

    /// <summary>
    /// List replace
    /// </summary>


    static void Main(string[] args)
    {

        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //string str = "ffe efw Îëüøåâñêèé Àëåêñåé Þðüåâè÷ суанрт132";
           
            string GetFileAssemb = Assembly.GetEntryAssembly().Location;
            string AppFolder = GetFileAssemb.Substring(0, GetFileAssemb.LastIndexOf('\\') + 1);
            var Loggerpath = Path.Combine(AppFolder, "logs", "logfile.log");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.File(Loggerpath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            var configPath = Path.Combine(AppFolder, "appsettings.json");

            string json = File.ReadAllText(configPath);

            var myConfig = JsonConvert.DeserializeObject<FileConfig>(json);
            Replacements = myConfig.FileSettings.Replacements;
            IsReplacements = myConfig.FileSettings.IsReplacements;
            htmlEntities = myConfig.FileSettings.htmlEntities;
            searchTextBySelector = myConfig.FileSettings.SearchTextBySelector;
            priorityGroups = myConfig.FileSettings.PriorityGroups;
            extensionMapping = myConfig.FileSettings.ExtensionMapping;

            if (args.Length < 2)
            {
                Log.Error($"min2: CopyFiles <inputFolder> outputFolder>");
                //Console.WriteLine("min2: CopyFiles <inputFolder> <outputFolder>");
                return;
            }
            // Определяем имя Active Directory и учетную запись
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            Log.Information($"account: {identity.Name.Split('\\')[0]}\\{identity.Name.Split('\\')[1]}");
            inputFolder = args[0];
            outputFolder = args[1];
            Log.Information($"inputFolder: {inputFolder}");
            Log.Information($"outputFolder: {outputFolder}");

            //init parse
            parserHtml = new ParserHtml();

            CopyFiles();
            parserHtml.dispose();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An error occurred while copying files");
        }
        return;
    }

    static void CopyFiles()
    {
        try
        {
            if (!Directory.Exists(outputFolder))
            {
                Log.Information($"Step1!Directory.Exists: {outputFolder}");
                Directory.CreateDirectory(outputFolder);
                Log.Information($"Step2!Directory.Exists: {outputFolder}");
            }
            string[] textFileExtensions = priorityExtensions;
            var extensionMappings = extensionMapping
                .SelectMany(kvp => kvp.Value.Select(ext => new { Group = kvp.Key, Extension = ext.ToLower() }))
                .ToDictionary(x => x.Extension, x => x.Group);

            var groupedFiles = Directory.EnumerateFiles(inputFolder, "*", SearchOption.AllDirectories)
                .GroupBy(file => {
                    string ext = Path.GetExtension(file).ToLower();
                    return extensionMappings.TryGetValue(ext, out string group) ? group : "other";
                })
                .OrderBy(g => g.Key == "HTML" ? -1 : Array.IndexOf(priorityGroups, g.Key))
                .ThenBy(g => g.Key).ToArray();


            var tempGroupHtml = new List<string>();
            foreach (var group in groupedFiles)
            {
                //Console.WriteLine($"Расширение: {group.Key}");

                // Проверяем, имеет ли файл текстовое расширение
                var ext = group.Key;
                var isExt = true;

                if (group.Key == "HTML" )//в первый раз восстанавливаем кодировку и ищем нужный страницы для поиска
                {                 
                    foreach (string file in group)
                    { 
                        tempGroupHtml.Add(file);
                        commonJob(file, ext, isExt); //имена реплейсов которые мы заменим тут в новом прогонке не учитываем добавим булл  ignorejson
                    }
                }
                else if (group.Key == "JSON")
                {
                    foreach (string file in group)
                    {
                        commonJob(file, ext, isExt);
                    }
                }
                else if (group.Key == "JavaScript")
                {
                    foreach (string file in group)
                    {
                        commonJob(file, ext, isExt);
                    }
                }
                else
                {
                    foreach (string file in group)
                    {
                        commonJob(file, ext, false);
                    }
                    //другие расширения
                    
                }
            }
            if (tempGroupHtml.Count() == 0)
            {
                Log.Error($"{nameof(CopyFiles)}:tempGroupHtml_Count == 0");
            }
            Log.Information($"Step2:tempGroupHtml.Count: {tempGroupHtml.Count()}");
            foreach (var file in tempGroupHtml) //после поиска контента сделаем , новые замены в тексте,или выполнить модификации данных html
            {
                commonJob(file, "HTML", true,false,true);
            }
            
        }
        catch (Exception ex)
        {

            Log.Error($"{nameof(CopyFiles)}::{ex.Message}");
        }

        Log.Information($"Deplay File OK");
    }
    /// <summary>
    /// isFileCopy -не копируем файл, по умолчанию всегда копируем
    /// </summary>
    /// <param name="file"></param>
    /// <param name="ext"></param>
    /// <param name="isExt">Расширение для модификации файла,пример Html</param>
    /// <param name="isFileCopy"></param>
    /// <returns></returns>
    static string commonJob(string file,string ext, bool isExt,bool isFileCopy =true,bool isRepitorrepeatingTask = false)
    {
        string relativePath = Path.GetRelativePath(inputFolder, file);
        string destinationFile = Path.Combine(outputFolder, relativePath);
        if (!Directory.Exists(Path.GetDirectoryName(destinationFile)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(destinationFile));
        }
        try
        {
            if (isFileCopy)
            {
                File.Copy(file, destinationFile, true);
            }
           
            if (isExt)
            {
                if (isFileCopy)
                {
                    Thread.Sleep(1);
                }
               
                if (IsReplacements)
                {
                    ReplaceInFile(destinationFile, ext, isRepitorrepeatingTask);
                }
            }
            //Log.Information($"file {relativePath} ok copy.");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error copying {relativePath}: {ex.Message}");
        }
        return destinationFile;
    }
    //static string commonJobHTML(string file,string ext, bool isExt)
    //{
    //    string relativePath = Path.GetRelativePath(inputFolder, file);
    //    string destinationFile = Path.Combine(outputFolder, relativePath);
    //    if (!Directory.Exists(Path.GetDirectoryName(destinationFile)))
    //    {
    //        Directory.CreateDirectory(Path.GetDirectoryName(destinationFile));
    //    }
    //    try
    //    {
    //        File.Copy(file, destinationFile, true);
    //        if (isExt)
    //        {
    //            Thread.Sleep(1);
    //            if (IsReplacements)
    //            {
    //                ReplaceInFile(destinationFile, ext,true);
    //            }
    //        }
    //        //Log.Information($"file {relativePath} ok copy.");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.Error.WriteLine($"Error copying {relativePath}: {ex.Message}");
    //    }
    //    return destinationFile;
    //}
    /// <summary>
    /// Производит  изменения в файле,ext - расширение,isRepitorrepeatingTask -ReplaceInFile используется более одного раза
    /// </summary>
    /// <param name="filePath"></param>
    static void ReplaceInFile(string filePath, string ext,bool isRepitorrepeatingTask =false)
    {
        try
        {
            var fileContent = filePath.ReadFile();
            if (!isRepitorrepeatingTask)
            {
                ReplaceHtmlEntities(ref fileContent);
                DecodeUnicodeEscapes(ref fileContent);
                DecodeHtmlEntities(ref fileContent);
                ReplacementsTextinDocument(ref fileContent);
                
                if (!Program.isSeacrhComplited && ext == "HTML")
                {
                    SearchFile(ref searchTextBySelector, filePath, fileContent, ext, true); //тут промежуточный класс для измений по шаблону,например скрытия элементов
                                                                     //fileContent = parserHtml.documentToString(); //return res text
                }
            }
            else
            { //step2
                parserHtml = HtmlChange(filePath, fileContent, ext, true);
                //parserHtml.ExecuteScript(""); //тут промежуточный класс для измений по шаблону,например скрытия элементов
                parserHtml.removeDuplicates(ref searchTextBySelector);
                fileContent = parserHtml.documentToString();
                parserHtml.dispose();
                ReplacementsTextinDocument(ref fileContent,Program.ReplacementsInner);
            }
            filePath.WriteFile(fileContent);



        }
        catch (Exception ex)
        {
            Log.Error($"{nameof(ReplaceInFile)} error:{ex.Message}");
            return;
        }
    }
    /// <summary>
    /// Program.Replacements класс в который попадают найденные элементы для их изменений по типу
    /// </summary>
    /// <param name="searchTextBySelectors"></param>
    public static void SearchFile(ref List<SearchTextBySelector> searchTextBySelectors, string filePath, string? Content, string ext, bool isParsHtml)
    {
        foreach (var searchTextBySelector in searchTextBySelectors)
        {
            if (!searchTextBySelector.Enabled)
            {
                continue;
            }
            if (searchTextBySelector.type == "removeDuplicate")
            {
                continue;
            }
            parserHtml = HtmlChange(filePath, Content, ext, true);
            //parserHtml.ExecuteScript(""); //тут промежуточный класс для измений по шаблону,например скрытия элементов
            parserHtml.SearchFile(searchTextBySelector); //тут промежуточный класс для измений по шаблону,например скрытия элемен
        }
    }


    /// <summary>
    /// Возращает экземпляр класса для работы с дом элементами
    /// </summary>
    /// <param name="ext"></param>
    /// <param name="Content">Содержимое файла</param>
    /// <param name="isChangeText">изменяет DOM</param>
    private static ParserHtml HtmlChange(string filePath,string? Content, string ext, bool isParsHtml)
    {
        if (isParsHtml && ext == "HTML")
        {
            parserHtml.init(filePath);
            parserHtml.ParseDocument(Content);
            return parserHtml;
        }
        return null;
    }

    private static void ReplacementsTextinDocument(ref string? fileContent, List<Replacement>? replacementsInner =null)
    {
        List<Replacement> Replace = new List<Replacement>();
        if (replacementsInner !=null)
        {
            Replace = replacementsInner.Distinct().ToList();
        }
        else
        {
            Replace = Replacements;
        }
        foreach (var replacement in Replace)
        {
            var newstr = replacement.NewStr;
            if (replacement.type == "securityStar")
            {
                newstr = "*****";
            }
            fileContent = fileContent?.Replace(replacement.OldStr, newstr);
            //replacement.isUsed = true;
        }
    }
}