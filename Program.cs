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


class Program
{
    public const string invalidChars = "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýþÿ";
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
                if (IsReplacements && textFileExtensions.Contains(Path.GetExtension(file).ToLower()))
                {
                    ReplaceInFile(file);
                }

                string relativePath = Path.GetRelativePath(inputFolder, file);
                string destinationFile = Path.Combine(outputFolder, relativePath);
                // Создаем папки для каждого файла, если необходимо
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

    static void ReplaceInFile(string filePath)
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
            foreach (var replacement in Replacements)
            {
                fileContent = fileContent.Replace(replacement.OldStr, replacement.NewStr);
                var e = ContainsInvalidCharacters(fileContent);
                if (e)
                {
                    var t = DecodeCyrillic(fileContent);//Windows-1252
                }

            }
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