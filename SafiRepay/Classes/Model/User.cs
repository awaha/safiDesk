using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SafiRepay.Classes.Model
{
    class User
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string phoneNumber { get; set; }
        public string cellPhoneNumber { get; set; }
        public string email { get; set; }
        public string socialSecurityNumber { get; set; }
        public string grossSalary { get; set; }



        public User()
        {



        }
    }
}
