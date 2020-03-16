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
using System.Windows.Forms;

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
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        public static String post(String route, object json)
        {
            string routeAPI = "http://192.168.134.128:8000/api/" + route;

            RestClient client = new RestClient(routeAPI);
            //post
            RestRequest request = new RestRequest();
            request.Method = Method.POST;

            request.AddJsonBody(json);

            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
            String content = response.Content; // {"message":" created."}
            Console.WriteLine("status : " + response.StatusCode.ToString());
            Console.WriteLine("content : " + content);
            return content;
        }

        
        public static String test1(String route,object json)
        {
            string routeAPI = "http://192.168.134.128:8000/api/" + route;

            RestClient client = new RestClient(routeAPI);
            //post
            RestRequest request = new RestRequest();
            request.Method = Method.POST;

            request.AddJsonBody(new {login = "dandre",password = "oppg5"});

            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
            String content = response.Content; // {"message":" created."}
            Console.WriteLine("status : " + response.StatusCode.ToString());
            Console.WriteLine("content : " + content);
            return content;
        }
        
    }
}
