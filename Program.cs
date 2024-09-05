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



class Program
{
    public static Encoding[] encodings = new Encoding[]
        {
            Encoding.GetEncoding("Windows-1252"),
            Encoding.GetEncoding("Windows-1251"),
            Encoding.GetEncoding("ISO-8859-5")
        };

    public const string invalidChars = "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýþÿ";

    static Dictionary<string, string> htmlEntities;

    static string ConvertToRussian(string input)
    {
        string bestResult = input;
        int maxRussianChars = 0;

        foreach (var encoding in encodings)
        {
            string result = Convert1252_1251(input, encoding);
            int russianChars = result.Count(c => (c >= 'А' && c <= 'я') || c == 'Ё' || c == 'ё');

            if (russianChars > maxRussianChars)
            {
                maxRussianChars = russianChars;
                bestResult = result;
            }
        }

        return bestResult;
    }



        static string ReplaceHtmlEntities(string input)
    {
        return Regex.Replace(input, "&[a-zA-Z]+;", match =>
        {
            string entity = match.Value;
            return htmlEntities.ContainsKey(entity) ? htmlEntities[entity] : entity;
        });
    }
    static string HtmlDecode(string input)
    {
        //string encodedString = "&#1046;&#1091;&#1088;&#1085;&#1072;&#1083; &#1040;&#1058;&#1055;";
        return WebUtility.HtmlDecode(input);
    }
    static string Convert1252_1251(string input, Encoding encoding)
    {
        Encoding utf8 = Encoding.UTF8;

        return new string(input.Select(c =>
        {
            if (c >= '\u0080' && c <= '\u00FF')
            {
                byte[] bytes = new byte[] { (byte)c };
                string converted = encoding.GetString(bytes);
                return utf8.GetString(encoding.GetBytes(converted))[0];
            }
            return c;
        }).ToArray());
        ////string input = "Ãèäðîñèñòåìà» (ãèäðàâëè÷åñêèé è òåïëîâîé ðàñ÷åò íàïîðíûõ òðóáîïðîâîäîâ ðàçíîîáð";
        ////byte[] bytes = Encoding.GetEncoding("Windows-1252").GetBytes(input);
        ////string output = Encoding.GetEncoding("Windows-1251").GetString(bytes);
        //// Создаем кодировки
        //Encoding win1251 = Encoding.GetEncoding("Windows-1251");
        //Encoding utf8 = Encoding.UTF8;

        //// Преобразуем посимвольно
        //return new string(input.Select(c =>
        //{
        //    // Если символ в диапазоне, который нуждается в конвертации
        //    if (c >= '\u0080' && c <= '\u00FF')
        //    {
        //        // Конвертируем символ
        //        byte[] bytes = new byte[] { (byte)c };
        //        string converted = win1251.GetString(bytes);
        //        return utf8.GetString(win1251.GetBytes(converted))[0];
        //    }
        //    // Иначе оставляем символ без изменений
        //    return c;
        //}).ToArray());
        //return output;
    }


    static bool ContainsInvalidCharacters(string text)
    {
        return text.Any(c => invalidChars.Contains(c));
    }
    public static string DecodeCyrillic(string text)
    {
        string restoredText = text;
        string[] cyrillicParts = Regex.Split(text, @"[a-zA-Z0-9\s]+");
        foreach (string part in cyrillicParts)
        {
            if (!string.IsNullOrEmpty(part))
            {
                byte[] bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(part);
                string decodedPart = Encoding.GetEncoding("windows-1251").GetString(bytes);
                restoredText = restoredText.Replace(part, decodedPart);
            }
        }
        return restoredText;
    }

    /// <summary>
    /// List replace
    /// </summary>
    private static List<Replacement> Replacements = new List<Replacement>();
    private static bool IsReplacements;

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

            if (args.Length < 2)
            {
                Log.Error($"min2: CopyFiles <inputFolder> outputFolder>");
                //Console.WriteLine("min2: CopyFiles <inputFolder> <outputFolder>");
                return;
            }
            // Определяем имя Active Directory и учетную запись
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            string adName = identity.Name.Split('\\')[0];
            string userName = identity.Name.Split('\\')[1];

            Log.Information($"account: {adName}\\{userName}");
            string inputFolder = args[0];
            string outputFolder = args[1];
            Log.Information($"inputFolder: {inputFolder}");
            Log.Information($"outputFolder: {outputFolder}");
            CopyFiles(inputFolder, outputFolder);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An error occurred while copying files");
        }
        return;
    }

    static void CopyFiles(string inputFolder, string outputFolder)
    {
        try
        {
            if (!Directory.Exists(outputFolder))
            {
                Log.Information($"Step1!Directory.Exists: {outputFolder}");
                Directory.CreateDirectory(outputFolder);
                Log.Information($"Step2!Directory.Exists: {outputFolder}");
            }
            string[] textFileExtensions = { ".htm", ".html", ".json", ".js" }; // Добавьте другие расширения по необходимости

            foreach (string file in Directory.EnumerateFiles(inputFolder, "*", SearchOption.AllDirectories))
            {
                // Проверяем, имеет ли файл текстовое расширение
                var ext = Path.GetExtension(file).ToLower();
                if (IsReplacements && textFileExtensions.Contains(ext))
                {
                    ReplaceInFile(file, ext);
                }

                string relativePath = Path.GetRelativePath(inputFolder, file);
                string destinationFile = Path.Combine(outputFolder, relativePath);
                if (!Directory.Exists(Path.GetDirectoryName(destinationFile)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(destinationFile));
                }
                try
                {
                    File.Copy(file, destinationFile, true);
                    //Log.Information($"file {relativePath} ok copy.");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Error copying {relativePath}: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {

            Log.Error($"{nameof(CopyFiles)}::{ex.Message}");
        }

        Log.Information($"Deplay File OK");
    }

    static void ReplaceInFile(string filePath, string ext)
    {
        try
        {
            byte[] content;
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                content = new byte[fileStream.Length];
                fileStream.Read(content, 0, content.Length);
            }
            string fileContent = System.Text.Encoding.UTF8.GetString(content);

            fileContent = HtmlDecode(fileContent);
            fileContent = ReplaceHtmlEntities(fileContent);
            

            foreach (var replacement in Replacements)
            {
                fileContent = fileContent.Replace(replacement.OldStr, replacement.NewStr);
            }
            //foreach (var replacement in Replacements)
            //{
            //    string pattern = $@"\b{Regex.Escape(replacement.OldStr)}\b";
            //    fileContent = Regex.Replace(fileContent, pattern, replacement.NewStr);
            //}

            //var e = ContainsInvalidCharacters(fileContent);
            //if (e)
            //{
            //    //Log.Information($"cont");
            //    var t = DecodeCyrillic(fileContent);//Windows-1252
            //    fileContent = t;

            //}
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] updatedContent = System.Text.Encoding.UTF8.GetBytes(fileContent);
                fileStream.Write(updatedContent, 0, updatedContent.Length);
            }
        }
        catch (Exception ex)
        {
            Log.Error($"{nameof(ReplaceInFile)} error:{ex.Message}");
            return;
        }
    }
}