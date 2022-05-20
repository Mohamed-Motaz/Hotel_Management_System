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

        public static bool checkForResident(dynamic input)
        {
            dynamic obj = GetResident(input);
            if (obj is null)
                return false;
            else
                return true;
        }
    
        public static dynamic EditResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/edit", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
        public static dynamic AddResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/add", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
        public static dynamic DeleteResident(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/resident/delete", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
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
        public static dynamic DeleteWorker(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/delete", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
        public static dynamic EditWorker(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/edit", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }

        public static dynamic AddWorker(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/worker/add", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }

        // Sign in 

        public static dynamic SignIn(dynamic input)
        {

            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/main/signIn", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
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
            HttpResponseMessage response = Post("api/reservation/getActive", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> activeReservations = obj.lst;
            return activeReservations;
        }
        public static List<dynamic> GetResidentReservations(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/getResidentBookings", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> Reservations = obj.lst;
            return Reservations;
        }
        public static dynamic GetReservation(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/get", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }



        public static List<dynamic> GetAllReservations()
        {
            HttpResponseMessage response = Post("api/reservation/getAll", "");
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> Reservations = obj.lst;
            return Reservations;
        }
        public static dynamic AddReservation(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/add", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
        public static dynamic DeleteReservation(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/delete", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }

        public static dynamic EditReservation(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/edit", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
            
        }

        public static dynamic Checkout(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/checkout", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            return obj;
        }
        
        //Rooms
        public static List<object> GetAvailableRooms(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/reservation/builder", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<object> availableRooms = obj.lst;
            return availableRooms;
        }

        public static List<dynamic> GetReservedRoom(dynamic input)
        {
            string json = JsonConvert.SerializeObject(input);
            HttpResponseMessage response = Post("api/room/getReserved", json);
            string responseStr = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(responseStr, converter);
            List<dynamic> reservedRooms = obj.lst;
            return reservedRooms;
        }


    }
}