using Backend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public dynamic add([FromBody] string json) //api/resident/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);

            Resident resident = new Resident(obj.username,obj.age,obj.email,obj.phoneNumber,obj.password);
            resident.AddResident(resident);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] string json) //api/resident/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Resident resident = new Resident(obj.username, obj.age, obj.email, obj.phoneNumber, obj.password);
            resident.EditResident(resident);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            
            return resp;
        }

        [HttpPost]
        public dynamic delete([FromBody] string json) //api/resident/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Resident.deleteResident(obj.id);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            
            return resp;
        }

        [HttpPost]
        public dynamic get([FromBody] string json) //api/resident/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = JsonConvert.DeserializeObject(Resident.getResident(obj.id));
            return resp;
        }

        [HttpPost]
        public dynamic getAll() //api/resident/getAll
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(Manager.viewAllResidents());
            
            return resp;
        }

    }
}