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

            [JsonProperty("IsReplacements", NullValueHandling = NullValueHandling.Ignore)]
            public bool IsReplacements { get; set; }
        }

        public class Replacement
        {
            [JsonProperty("OldStr", NullValueHandling = NullValueHandling.Ignore)]
            public string OldStr { get; set; }

            [JsonProperty("NewStr", NullValueHandling = NullValueHandling.Ignore)]
            public string NewStr { get; set; }
        }

        public class FileConfig
        {
            [JsonProperty("FileSettings", NullValueHandling = NullValueHandling.Ignore)]
            public FileSettings FileSettings { get; set; }
        }
    }
