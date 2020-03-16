
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
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String login { get; set; }
        public String birthdate { get; set; }
        public String codePostal { get; set; }
        public String city { get; set; }
        public String address { get; set; }
        public String userTypeId { get; set; }
        public String districtId { get; set; }
        public String hireDate { get; set; }
        public String fireDate { get; set; }
        public String isActivated { get; set; }
        public String email { get; set; }
        public String email_verified_at { get; set; } 
        public String apiToken { get; set; }
        public String notorietyCoef { get; set; }
        public String complementarySpeciality { get; set; }
        public String created_at { get; set; }
        public String updated_at { get; set; }

        //public String data { get; set; }


        public static User getLogin(string login, string password)
        {
            /*RAO.post("login", new { 
                login = "dandre", 
                password = "oppg5" 
            });*/

            string response = RAO.post("login", new
            {
                login = login,
                password = password
            });

            // Transforme la chaine de caractère du RAO en objet JSON = parser
            JObject jsonParse = JObject.Parse(response);

            if (jsonParse["message"].ToString() == "Success")
            {
                //Console.WriteLine(jsonParse["data"]);
                // Retourne un objet de la classe User à partir de la chaine de caractère de l'objet JSON parsé avec clef "content"
                return JsonConvert.DeserializeObject<User>(jsonParse["user"].ToString());
            }
            else
            {
                return null;
            }

        }


    }
}