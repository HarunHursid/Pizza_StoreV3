using Pizza_StoreV3.Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Pizza_StoreV3.Helpers
{
        public class JsonFileReader
        {
            public static Dictionary<int, Pizza> ReadJson(string JsonFileName)
            {
                string jsonString = File.ReadAllText(JsonFileName);
                return JsonConvert.DeserializeObject<Dictionary<int, Pizza>>(jsonString);
            }
        }

    
}
