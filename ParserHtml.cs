
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using AngleSharp.Css.Dom;
using System.Collections;
using System.Reflection.Metadata;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Js;
using AngleSharp.Dom; // Важно добавить этот using
using Jint;
using AngleSharp.Scripting;
using System.Text.RegularExpressions;
using copyFile.Extensions;
using System.Runtime.InteropServices;
public static class AngleSharpExtensions
{
    /// <summary>
    /// Поиск селеткоров по тексту
    /// </summary>
    /// <param name="document"></param>
    /// <param name="text"></param> 
    /// <returns></returns>
    public static List<IElement> FindElementsByText(this IDocument document, string text)
    {
        return document.All.Where(e => e.TextContent.Contains(text)).ToList();
    }
    /// <summary>
    /// состоавляем селектор для возможного поиска через document.QuerySelectorAll
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public static string GetSelectorCustom(this IElement? element)
    {
        if (element == null)
            return string.Empty;

        var selector = new List<string>();
        while (element != null && element.NodeType == AngleSharp.Dom.NodeType.Element)
        {
            string currentSelector = element.NodeName.ToLower();

            // Добавляем id, если он есть
            if (!string.IsNullOrEmpty(element.Id))
            {
                currentSelector += $"#{element.Id}";
                selector.Insert(0, currentSelector);
                break; // Id уникален, поэтому можно остановиться здесь
            }
            // Добавляем классы, если они есть
            var classes = element.ClassList.Where(c => !string.IsNullOrEmpty(c)).ToList();
            if (classes.Any())
            {
                currentSelector += $".{string.Join(".", classes)}";
            }
            // Добавляем data-атрибуты, если они есть
            var dataAttributes = element.Attributes
                .Where(attr => attr.Name.StartsWith("data-"))
                .ToList();
            if (dataAttributes.Any())
            {
                foreach (var attr in dataAttributes)
                {
                    currentSelector += $"[{attr.Name}='{attr.Value}']";
                }
            }

            // Если у элемента нет ни id, ни классов, ни data-атрибутов, используем nth-of-type
            else if (currentSelector == element.NodeName.ToLower())
            {
                var sameTypeElements = element.Parent?.ChildNodes.Where(e => e.NodeName == element.NodeName).ToList();
                var index = sameTypeElements?.IndexOf(element) + 1;
                currentSelector += $":nth-of-type({index})";
            }

            selector.Insert(0, currentSelector);
            element = element.ParentElement;
        }

        return string.Join(" > ", selector);
    }
}


namespace copyFile
{
    /// <summary>
    /// AngleSharp
    /// </summary>
    public class ParserHtml
    {
        public string? filePath = null;
        private readonly IConfiguration config;
        private IBrowsingContext context;
        private JsScriptingService? jsEngine;
        private IHtmlParser? parser;
        private Engine engine;
        private IHtmlDocument document;

        public ParserHtml()
        {
            config = Configuration.Default

               .WithDefaultLoader().WithJs(); // Включаем поддержку JavaScript;

            context = BrowsingContext.New(config);
            jsEngine = context.GetService<JsScriptingService>();

            // Создаем парсер
            parser = context.GetService<IHtmlParser>();


        }
        public void init(string file)
        {
            filePath = file;
        }
        ////        var jsCode = @"
        ////    var rows = Array.from(document.getElementById('myTable').rows);
        ////    return rows.map(row => Array.from(row.cells).map(cell => cell.innerText)).slice(1);
        ////";

        ////        // Выполните JavaScript код и получите результат как двумерный массив строк
        ////        var tableData = document.ExecuteScript<string[][]>(jsCode);






        /// <summary>
        /// Выполняет код на странице
        /// </summary>
        /// <param name = "file" ></ param >
        public object ExecuteScript(string jsCode)
        {
            return null;
        }

        public void dispose()
        {
            filePath = null;
            parser = null;
            context?.Dispose();
            document?.Dispose();
        }

        /// <summary>
        /// Открывает файл 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public async Task<bool> FileRead(string path)
        {
            try
            {
                filePath = path;
                string text = File.ReadAllText(filePath);
                ParseDocument(text);
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// распознает html и переводит в тип document
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool ParseDocument(string text)
        {
            try
            {
                document = parser?.ParseDocument(text);

            }
            catch (Exception ex)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// Запись изменения документа в файл
        /// </summary>
        /// <returns></returns>
        public bool FileWrite()
        {
            try
            {
                // Сохраняем изменения
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(documentToString());
                }
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// Document to string? возвращает html в виде измененного текста
        /// </summary>
        /// <returns></returns>
        public string documentToString()
        {
            try
            {
                // Сохранить изменения в документе
                //var modifiedHtml = document.ToHtml();

                string html = document.DocumentElement.OuterHtml;
                return html;

            }
            catch (Exception ex)
            {
                return "";
            }

        }


        /// <summary>
        /// Манипуляции с документом,промежуточный класс для измений по шаблону,например скрытия элементов
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public bool ChangeText()
        {
            try
            {

                // Теперь вы можете вносить изменения в документ
                // Например, найдем элемент по ID и изменим его содержимое
                var elements = document.FindElementsByText("Основные понятия");
                if (elements != null && elements.Any())
                {
                    //element.TextContent = "Новое содержимое";
                    foreach (var el in elements)
                    {    // Выводим текущий текст и селектор
                         //Console.WriteLine($"Текущий текст: {el.TextContent}");
                         // Console.WriteLine($"Селектор: {el.GetSelector()}");
                         // Вариант 1: Установка атрибута style
                         //link.SetAttribute("style", "display: none;");

                        //// Вариант 2: Добавление класса
                        //link.ClassList.Add("hidden");

                        //// Вариант 3: Установка data-атрибута
                        //link.SetAttribute("data-hidden", "true");

                        //// Вариант 4: Изменение текста (если нужно)
                        //link.TextContent = "Скрытый текст";

                        //// Вариант 5: Обертывание в span с классом
                        //var span = document.CreateElement("span");
                        //span.ClassName = "hidden-link";
                        //link.Parent.ReplaceChild(span, link);
                        //span.AppendChild(link);



                        var str = el.GetSelectorCustom();
                        //var style = el.GetStyleSheets().ToList();//.Display = "none"; // Это полностью скроет ссылку, включая текст
                        //foreach (var item in style)
                        //{
                        //    Console.WriteLine(item.ToCss());
                        //}
                        if (el.TagName == "H2") // Применяем стили только к заголовкам H2
                        {

                            el.InnerHtml = "<strong><em><span style='color: red;'>Основные понятия</span></em></strong>";
                        }
                        Console.WriteLine(str);
                    }
                }

                //// Или добавим новый элемент
                //var newElement = document.CreateElement("p");
                //newElement.TextContent = "Это новый параграф";
                //document.Body.AppendChild(newElement);            //// Или добавим новый элемент
                //var newElement = document.CreateElement("p");
                //newElement.TextContent = "Это новый параграф";
                //document.Body.AppendChild(newElement);



                Console.WriteLine("Документ успешно изменен и сохранен.");
            }
            catch (Exception)
            {

                return false;
            }
            return true;


        }
        public IElement? QuerySelector(string selector)
        {
            try
            {
                return document.QuerySelector(selector);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public IHtmlCollection<IElement> QuerySelectorAll(string selector)
        {
            try
            {
                return document.QuerySelectorAll(selector);
            }
            catch (Exception)
            {

                return null;
            }
        }





        /// <summary>
        /// Program.Replacements класс в который попадают найденные элементы для их изменений по типу
        /// </summary>
        /// <param name="searchTextBySelectors"></param>
        public void SearchFile(SearchTextBySelector searchTextBySelector)
        {

            // if (!searchTextBySelector.Enabled)
            // {
            //     continue;
            // }


            // if (searchTextBySelector.type == "removeDuplicate")
            // {
            //     continue;
            // }
            //init(filePath);
            //ParseDocument(Content);




            var selector = searchTextBySelector.selector;

            var els = QuerySelectorAll(selector);
            foreach (var el in els)
            {
                if (el != null && el.TextContent.Trim() == searchTextBySelector.text)
                {
                    searchTextBySelector.isfile = true;
                    searchTextBySelector.filePath = filePath;
                    var selectCS = searchTextBySelector.selectorSelectContentScrap;
                    IElement currentSection = null;
                    if (searchTextBySelector.sectionName != null && searchTextBySelector.sectionName.Length > 2)
                    {
                        var contentS = QuerySelectorAll(searchTextBySelector.sectionselectorName).ToList();
                        if (contentS == null)
                        {
                            continue; //инфы нет
                        }
                        foreach (var sect in contentS)
                        {
                            if (sect != null && sect.TextContent.Trim() == searchTextBySelector.sectionName)
                            {
                                currentSection = sect;
                                break;
                            }
                        }
                    }
                    if (currentSection != null && selectCS != null && selectCS.Length > 3)
                    {
                        var contentS = currentSection.ParentElement.QuerySelectorAll(selectCS).ToList();
                        if (contentS == null)
                        {
                            continue; //инфы нет
                        }
                        //List<string> collReplaceText = new List<string>();
                        foreach (var content in contentS)
                        {
                            Program.isSeacrhComplited = true;
                            Program.IsReplacements = true; //внутренние замены
                                                           //collReplaceText.Add();

                            Program.ReplacementsInner.Add(new Replacement()
                            {
                                OldStr = content.TextContent.Trim(),
                                type = searchTextBySelector.type
                            });

                        }
                    }
                }
            }
        }

        public bool removeDuplicates(List<SearchTextBySelector> searchTextBySelectors)
        {
            bool flag = false;
            foreach (var searchTextBySelector in searchTextBySelectors)
            {
                if (searchTextBySelector.type == "removeDuplicate")
                {
                    flag = removeDuplicate(searchTextBySelector);
                    continue;
                }
            }
            return flag;
        }
        private bool removeDuplicate(SearchTextBySelector searchTextBySelector)
        {
            if ((searchTextBySelector.selector == null))
            {
                return false;
            }
            if (searchTextBySelector.selector.StartsWith("table") && !searchTextBySelector.selector.EndsWith("td"))
            {
                return removeDuplicateNormalizeContent(searchTextBySelector);
            }
            else
            {
                return removeDuplicateForSelector(searchTextBySelector);

            }
        }
        /// <summary>
        /// Удаление дубликатов по селектору
        /// </summary>
        /// <param name="searchTextBySelector"></param>
        private bool removeDuplicateForSelector(SearchTextBySelector searchTextBySelector)
        {
            bool flag = false;
            var tdElements = document.QuerySelectorAll(searchTextBySelector.selector);

            foreach (var td in tdElements)
            {
                // Множество для хранения уникальных ссылок
                var uniqueLinks = new HashSet<string>();
                // Список элементов для удаления
                var elementsToRemove = new List<INode>();
                // Проходим по всем дочерним узлам td
                for (var i = 0; i < td.ChildNodes.Length; i++)
                {
                    var node = td.ChildNodes[i];
                    if (node is IHtmlImageElement)
                    {
                        var link = node.NextSibling as IHtmlAnchorElement;
                        if (link != null)
                        {
                            var href = link.GetAttribute("href");
                            if (!uniqueLinks.Contains(href))
                            {
                                uniqueLinks.Add(href);
                            }
                            else
                            {
                                // Если ссылка дубликат, помечаем для удаления изображение, ссылку и <br>
                                elementsToRemove.Add(node); // Изображение
                                elementsToRemove.Add(link); // Ссылка
                                if (i + 2 < td.ChildNodes.Length && td.ChildNodes[i + 2] is IHtmlBreakRowElement)
                                {
                                    elementsToRemove.Add(td.ChildNodes[i + 2]); // <br>
                                }
                            }
                            i += 2; // Пропускаем ссылку и <br>
                        }
                    }
                    else if (node is IHtmlAnchorElement)
                    {
                        var link = node as IHtmlAnchorElement;
                        if (link != null)
                        {
                            var href = link.GetAttribute("href");
                            if (!uniqueLinks.Contains(href))
                            {
                                uniqueLinks.Add(href);
                            }
                            else
                            {
                                // Если ссылка дубликат, помечаем для удаления изображение, ссылку и <br>
                                elementsToRemove.Add(link); // Ссылка
                                if (i + 2 < td.ChildNodes.Length && td.ChildNodes[i + 2] is IHtmlBreakRowElement)
                                {
                                    elementsToRemove.Add(td.ChildNodes[i + 2]); // <br>
                                }
                            }
                            i += 2; // Пропускаем ссылку и <br>
                        }
                    }
                }
                foreach (var element in elementsToRemove)
                {
                    td.RemoveChild(element);
                }
                // Удаляем последний <br>, если он есть
                var lastChild = td.LastChild;
                if (lastChild is IHtmlBreakRowElement)
                {
                    td.RemoveChild(lastChild);
                }
                // Удаляем лишние пробелы и переносы строк
                if (searchTextBySelector.removeSpace)
                {
                    td.InnerHtml = Regex.Replace(td.InnerHtml, @">\s+<", "><");
                    td.InnerHtml = Regex.Replace(td.InnerHtml, @"\s+", " ").Trim();
                }        

                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// Удаление дубликатов по всей таблице,
        /// </summary>
        /// <param name="searchTextBySelector"></param>
        /// <exception cref="NotImplementedException"></exception>
        private bool removeDuplicateNormalizeContent(SearchTextBySelector searchTextBySelector)
        {
            bool flag = false;
            // Находим таблицу
            var tables = document.QuerySelectorAll("table");
            if (tables.Count() > 0)
            {
                foreach (var table in tables)
                {


                    // Множество для хранения уникального содержимого
                    var uniqueContents = new HashSet<string>();

                    // Список элементов для удаления
                    var rowsToRemove = new List<IElement>();

                    foreach (var tr in table.QuerySelectorAll("tr"))
                    {
                        // Нормализуем содержимое строки
                        var normalizedContent = tr.InnerHtml.NormalizeContent();

                        if (!uniqueContents.Contains(normalizedContent))
                        {
                            uniqueContents.Add(normalizedContent);
                        }
                        else
                        {
                            rowsToRemove.Add(tr);
                        }
                    }

                    // Удаляем дублирующиеся строки
                    foreach (var row in rowsToRemove)
                    {
                        row.Remove();
                    }
                    // Удаляем лишние пробелы и переносы строк
                    if (searchTextBySelector.removeSpace)
                    {
                        table.InnerHtml = Regex.Replace(table.InnerHtml, @">\s+<", "><");
                        table.InnerHtml = Regex.Replace(table.InnerHtml, @"\s+", " ").Trim();
                    }
                    flag = true;
                }
            }
            return flag;
        }
    }
}
