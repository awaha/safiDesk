using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace SafiRepay.Classes.RAO
{
    class RAO
    {
        public static string get(string url, string apikey = null)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi + "/");

            RestRequest request = new RestRequest();
            request.Resource = url;
            IRestResponse response = client.Execute(request);

            return response.Content;
        }
    }
}
