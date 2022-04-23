using Backend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Routing;

namespace Backend.Controllers
{

    public class ResidentController : ApiController
    {
        

        [HttpPost]
        public string add(string json) //api/resident/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Resident resident = new Resident(obj.username,obj.age,obj.email,obj.phoneNumber,obj.password);
            resident.AddResident(resident);
            string res = JsonConvert.SerializeObject(true);
            return res;
        }

        [HttpPost]
        public string edit(string json) //api/resident/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Resident resident = new Resident(obj.username, obj.age, obj.email, obj.phoneNumber, obj.password);
            resident.EditResident(resident);
            string res = JsonConvert.SerializeObject(true);
            return res;
        }

        [HttpPost]
        public string get(string json) //api/resident/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            string res = JsonConvert.SerializeObject(Resident.getResident(obj.id));
            return res;
        }

        [HttpPost]
        public string delete(string json) //api/resident/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Resident.deleteResident(obj.id);
            string res = JsonConvert.SerializeObject(true);
            return res;
        }

        [HttpPost]
        public string getAll(string json) //api/resident/getAll
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            string res = JsonConvert.SerializeObject(Manager.viewAllResidents());
            return res;
        }

    }
}