using AngleSharp.Html.Parser;
using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using static System.Net.Mime.MediaTypeNames;
using AngleSharp.Dom;
using System.Xml.Linq;
using AngleSharp.Css.Dom;
using System.Collections;
using System.Reflection.Metadata;

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
        while (element != null && element.NodeType == NodeType.Element)
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
        private IHtmlParser? parser;
        private IHtmlDocument document;

        public ParserHtml()
        {
            config = Configuration.Default;
            context = BrowsingContext.New(config);
            // Создаем парсер
            parser = context.GetService<IHtmlParser>();
        }
        public void init(string file)
        {
            filePath = file;
        }
        public void dispose()
        {
            filePath = null;
            parser = null;
            context.Dispose();
            document.Dispose();
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
                document =  parser?.ParseDocument(text);

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
                string html =document.DocumentElement.OuterHtml;
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
        public void SearchFile(ref List<SearchTextBySelector> searchTextBySelectors)
        {
            foreach (var searchTextBySelector in searchTextBySelectors)
            {
                var selector = searchTextBySelector.selector;
                var els = QuerySelectorAll(selector);
                foreach (var el in els)
                {
                    if (el != null && el.TextContent.Trim() ==searchTextBySelector.text)
                    {
                        searchTextBySelector.isfile = true;
                        searchTextBySelector.filePath = filePath;
                        var selectCS = searchTextBySelector.selectorSelectContentScrap;
                        IElement currentSection =null;
                        if (searchTextBySelector.sectionName != null && searchTextBySelector.sectionName.Length > 2)
                        {
                            var contentS = QuerySelectorAll(searchTextBySelector.sectionselectorName).ToList();
                            if (contentS == null)
                            {
                                continue; //инфы нет
                            }
                            foreach (var sect in contentS)
                            {
                                if (sect != null && sect.TextContent.Trim() == searchTextBySelector.sectionName){
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
                                    type =searchTextBySelector.type
                                });

                            }
                        }
                    }
                }
                
            }
        }

        
    }
}
