using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SafiRepay.RAO
{
    class RAO
    {

        public static String get(String route)
        {

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            //get
            RestRequest request = new RestRequest();
            request.Resource = route;
            IRestResponse response = client.Execute(request);
            //Debug.WriteLine(route);
            //Debug.WriteLine(response.Content);
            return response.Content;
        }
        public static String put(String route, List<string> paramRoute)
        {

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            //put
            RestRequest request = new RestRequest(route, Method.PUT);
            request.AddParameter(paramRoute.First<string>(), paramRoute.Last<string>());
            Console.WriteLine(paramRoute.First<string>() +" "+ paramRoute.Last<string>());
            //request.AddJsonBody(new { paramRoute });
            client.Execute(request);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        public static String post(String route, String paramRoute)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            //post
            RestRequest request = new RestRequest(route, Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"" + paramRoute, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        
    }
}
