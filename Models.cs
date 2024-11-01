using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyFile
{
    public class FileSettings
    {
        [JsonProperty("Replacements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Replacement> Replacements { get; set; }

        [JsonProperty("htmlEntities", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> htmlEntities { get; set; }

        [JsonProperty("SearchTextBySelector", NullValueHandling = NullValueHandling.Ignore)]
        public List<SearchTextBySelector> SearchTextBySelector { get; set; }
        [JsonProperty("ExtensionMapping", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string[]> ExtensionMapping { get; set; }
        [JsonProperty("PriorityGroups", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PriorityGroups { get; set; }

        [JsonProperty("IsReplacements", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsReplacements { get; set; }
    }

    public class Replacement
    {
        [JsonProperty("OldStr", NullValueHandling = NullValueHandling.Ignore)]
        public string OldStr { get; set; }

        [JsonProperty("NewStr", NullValueHandling = NullValueHandling.Ignore)]
        public string NewStr { get; set; }

        /// <summary>
        /// Тип определает, что делаем с контеном, можем заменить,можем спрятать, можем стереть, можем добавить цвета...и.т.д
        /// </summary>
        [JsonIgnore]
        public string type { get; set; } = "none";

        /// <summary>
        /// флаг была ли уже замена
        /// </summary>
        [JsonIgnore]
        public bool isUsed { get; set; } = false;
    }

    public class FileConfig
    {
        [JsonProperty("FileSettings", NullValueHandling = NullValueHandling.Ignore)]
        public FileSettings FileSettings { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class SearchTextBySelector
    {
        [JsonProperty("Enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool Enabled { get; set; }      
        
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string text { get; set; }       
        
        [JsonProperty("selector", NullValueHandling = NullValueHandling.Ignore)]
        public string selector { get; set; }
        
        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public string attribute { get; set; }
        
        [JsonProperty("selectorSelectContentScrap", NullValueHandling = NullValueHandling.Ignore)]
        public string selectorSelectContentScrap { get; set; } 
        
        [JsonProperty("sectionselectorName", NullValueHandling = NullValueHandling.Ignore)]
        public string sectionselectorName { get; set; }

         [JsonProperty("sectionName", NullValueHandling = NullValueHandling.Ignore)]
        public string sectionName { get; set; }
        
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string type { get; set; }//hide,securityStar...
        
        /// <summary>
        /// Названия найденного файла 
        /// </summary>
        [JsonIgnore]
        public string? filePath { get; set; }//
        
        /// <summary>
        /// Указывает,был найден файл по селектору и тексту внутри
        /// </summary>
        [JsonIgnore]
        public bool isfile { get; set; }//
        
        /// <summary>
        /// если стоит задача произвести выборку на этой страницы то оно попадает сюда
        /// </summary>
        [JsonIgnore]
        public object selectContent { get; set; }//
    }


}
