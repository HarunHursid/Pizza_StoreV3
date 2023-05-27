using Pizza_StoreV3.Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Pizza_StoreV3.Helpers
{
   
        public class JsonFileWriter
        {
            public static void WriteToJson(Dictionary<int, Pizza> pizzas, string JsonFileName)
            {
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(pizzas,
                                                                   Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(JsonFileName, output);
            }
        }
        
    
}
