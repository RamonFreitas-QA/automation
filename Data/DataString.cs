using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Data
{
    public class DataString
    {
        public JsonSerialize DataJson()
        {
            return  JsonConvert
                         .DeserializeObject<JsonSerialize>(File.ReadAllText(Directory
                                 .GetCurrentDirectory() + @"\palindromo.json"));
        }
    }
}
