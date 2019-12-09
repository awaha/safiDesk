using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SafiRepay.Classes.Model;

namespace SafiRepay.Classes.RAO
{
    class UserRAO
    {
        public User GetById(string userId)
        {

            // Transforme la chaine de caractère du RAO en objet JSON = parser
            JObject jsonParse = JObject.Parse(RAO.get("profile/find/" + userId));

            // Retourne un objet de la classe Employee à partir de la chaine de caractère de l'objet JSON parsé avec clef "content"
            return JsonConvert.DeserializeObject<User>(jsonParse["content"].ToString());
        }
    }
}
