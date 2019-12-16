using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace SafiRepay.RAO
{
    public class PackageType
    {
        public String id { get; set; }
        public String amountMax { get; set; }
        public String name { get; set; }
        public String message { get; set; }
        public List<PackageType> data { get; set; }
        public static List<PackageType> getFixedCosts()
        {
            // Transforme la chaine de caractère du RAO en objet JSON = parser
            JObject jsonParse = JObject.Parse(RAO.get("getFixedCosts/"));

            if (jsonParse["message"].ToString().CompareTo("ok") == 0)
            {
                List<PackageType> listes = new List<PackageType>();
                JArray jsonData = jsonParse["data"].ToObject<JArray>();
                List<PackageType> allPackageType = JsonConvert.DeserializeObject<List<PackageType>>(jsonData.ToString());
                foreach (PackageType onePackageType in allPackageType)
                {
                    listes.Add(onePackageType);
                }
                Console.WriteLine((JsonConvert.DeserializeObject<PackageType>(jsonParse.ToString())));
                // Retourne un objet de la classe PackageType à partir de la chaine de caractère de l'objet JSON parsé avec clef "content"
                //return JsonConvert.DeserializeObject<List<PackageType>>(jsonParse["data"].ToString());
                //listes.Add(JsonConvert.DeserializeObject<PackageType>(jsonData));
                return listes;
            }
            else
            {
                return null;
            }
        }

    }
}