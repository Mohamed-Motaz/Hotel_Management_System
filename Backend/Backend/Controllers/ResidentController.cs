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
        public dynamic add([FromBody] dynamic obj) //api/resident/add
        {
            Resident resident = new Resident(Convert.ToString(obj.username), Convert.ToInt32(obj.age), Convert.ToString(obj.email), Convert.ToString(obj.phoneNumber), Convert.ToString(obj.password));
            resident.AddResident(resident);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] dynamic obj) //api/resident/edit
        {
            Resident resident = new Resident(Convert.ToString(obj.username), Convert.ToInt32(obj.age), Convert.ToString(obj.email), Convert.ToString(obj.phoneNumber), Convert.ToString(obj.password));
            resident.EditResident(resident);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            
            return resp;
        }

        [HttpPost]
        public dynamic delete([FromBody] dynamic obj) //api/resident/delete
        {
            Resident.deleteResident(Convert.ToInt32(obj.id));
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            
            return resp;
        }

        [HttpPost]
        public dynamic get([FromBody] dynamic obj) //api/resident/get
        {
            dynamic resp = JsonConvert.DeserializeObject(Resident.getResident(Convert.ToInt32(obj.id)));
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