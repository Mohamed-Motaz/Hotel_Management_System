using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
        private static ExpandoObjectConverter converter = new ExpandoObjectConverter();
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
        // to getList
       /* private List<dynamic> getList(HttpResponseMessage response) 
        {
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr);
            List<dynamic> lst = JsonConvert.DeserializeObject<ExpandoObject><List<dynamic>>(obj);
            return lst;
        }*/

        //Resident Functions

        public static dynamic GetResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/get", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
    
        public static void EditResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/edit", json);
        }
        public static void AddResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/add", json);
        }
        public static void DeleteResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/delete", json);
        }
        public static List<dynamic> GetAllResidents()
        {
            HttpResponseMessage response = Post("api/resident/getAll", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> workers = obj.lst;
            return workers;
        }




        // Workers functions
        public static dynamic GetWorkerById(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/get", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
        public static List<dynamic> GetAllWorkers()
        {
            HttpResponseMessage response = Post("api/worker/getAll", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> workers = obj.lst; 
            return workers;
        }
        public static void DeleteWorker(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/delete", json);
        }
        public static void EditWorker(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/edit", json);
        }

        public static void AddWorker(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/add", json);
        }

        // Sign in 

        public static bool SignIn(dynamic input)
        {

            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/main/signIn", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            if (obj.type != "")
                return true;
            else
                return false;
        }

        public static dynamic DashBoard()
        {
            HttpResponseMessage response = Post("api/manager/dashboard", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }


        // Reservations
        public static List<dynamic> GetActiveReservations()
        {
            HttpResponseMessage response = Post("api/reseravtion/getActive", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> activeReservations = JsonConvert.DeserializeObject<List<dynamic>>(obj, converter);
            return activeReservations;
        }

        public static List<dynamic> GetAllReservations()
        {
            HttpResponseMessage response = Post("api/reservation/get", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> Reservations = JsonConvert.DeserializeObject<List<dynamic>>(obj, converter);
            return Reservations;
        }
        public static void AddReservation(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/add", json);
        }
        public static void DeleteReservations(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/delete", json);
        }

        public static bool EditReservation(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/Edit", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            bool succeed = Convert.ToBoolean(obj.boolName);
            return succeed;
        }
        
        //Rooms
        public static List<string> GetAvailableRooms()
        {
            HttpResponseMessage response = Post("api/room/getAvailable", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<string> availableRooms = JsonConvert.DeserializeObject<List<string>>(obj, converter);
            return availableRooms;
        }

        public static dynamic GetReservedRoom(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/room/getReserved", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<string> reservedRooms = JsonConvert.DeserializeObject<List<string>>(obj, converter);
            return reservedRooms;
        }


    }
}
