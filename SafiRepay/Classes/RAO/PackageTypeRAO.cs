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
        public static List<PackageType> getFixedCosts()
        {
            List<PackageType> myPackageTypes = new List<PackageType>();
            // Transforme la chaine de caractère du RAO en objet JSON = parser
            //JArray jsonParse = JArray.Parse(RAO.get("getFixedCosts/"));
            //Console.WriteLine(jsonParse);
            /*foreach(JObject jObject in jsonParse)
            {
                myPackageTypes.Add(JsonConvert.DeserializeObject<PackageType>(jObject.ToString()));
            }
            //Console.WriteLine(myPackageTypes);*/
            return myPackageTypes;
        }

        public static void updateFixedCost(int packageTypeId, int packageTypeNewAmount)
        {
            List<string> str = new List<string>();
            str.Add("amountMax");
            str.Add(packageTypeNewAmount.ToString());
            RAO.put("/SetUpFixedCosts/"+packageTypeId+"/{amountMax}",str);
        }
    }
}