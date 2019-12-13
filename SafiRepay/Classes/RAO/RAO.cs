using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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
            Debug.WriteLine(route);
            Debug.WriteLine(response.Content);
            return response.Content;
        }
        public static String put(String route, String paramRoute)
        {

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            //put
            RestRequest request = new RestRequest(route, Method.PUT);
            request.AddJsonBody(paramRoute);
            IRestResponse response = client.Execute(request);
            //Debug.WriteLine(response.Content);
            return response.Content;
        }
    }
}
