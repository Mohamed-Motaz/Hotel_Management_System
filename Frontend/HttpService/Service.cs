using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.HttpService
{
    class Service
    {
        private static string url = "http://localhost:62377/";

        public static HttpResponseMessage Post(string action, string json)
        {
            using (var client = new HttpClient())
            {

                client.Timeout = new TimeSpan(0, 2, 0);
                client.BaseAddress = new Uri(url);
                var response = client.PostAsync(action,
                new StringContent(json, Encoding.UTF8, "application/json")).Result;

                if (response.IsSuccessStatusCode)
                    Console.WriteLine("Success");

                else
                    Console.WriteLine("Error");

                return response;
            }
        }

        public static dynamic GetAllResidents()
        {
            HttpResponseMessage response = Post("api/getResidents", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject(responseStr);
            return obj;
        }

        public static dynamic GetResidentById(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/getResidents", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject(responseStr);
            return obj;
        }
    }
}
