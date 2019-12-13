
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace SafiRepay.RAO
{
    public class User
    {
        public String id { get; set; }
        public String code { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        public String address { get; set; }
        public String postalCode { get; set; }
        public String city { get; set; }
        public String phone { get; set; }
        public String hireDate { get; set; }
        public String timespan { get; set; }
        public String api_token { get; set; }
        public String district_id { get; set; }
        public String message { get; set; }
        //public String data { get; set; }


        public static User getLogin(string login, string password)
        {
            // Transforme la chaine de caractère du RAO en objet JSON = parser
            JObject jsonParse = JObject.Parse(RAO.get("login/" + login + "/" + password));

            if (jsonParse["message"].ToString().CompareTo("ok") == 0)
            {
                //Console.WriteLine(jsonParse["data"]);
                // Retourne un objet de la classe Login à partir de la chaine de caractère de l'objet JSON parsé avec clef "content"
                return JsonConvert.DeserializeObject<User>(jsonParse.ToString());
            }
            else
            {
                return null;
            }

        }
    }
}