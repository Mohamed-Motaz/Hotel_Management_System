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
            Resident resident = new Resident(Convert.ToString(obj.userName), Convert.ToInt32(obj.age), Convert.ToString(obj.email), Convert.ToString(obj.phoneNumber), Convert.ToString(obj.password));
            dynamic resp = new ExpandoObject();
            resp.Success = resident.AddResident(resident);
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] dynamic obj) //api/resident/edit
        {
            Resident resident = new Resident(Convert.ToString(obj.userName), Convert.ToInt32(obj.age), Convert.ToString(obj.email), Convert.ToString(obj.phoneNumber), Convert.ToString(obj.password));
            dynamic resp = new ExpandoObject();
            resp.Success = resident.EditResident(Convert.ToInt32(obj.id), resident);
            return resp;
        }

        [HttpPost]
        public dynamic delete([FromBody] dynamic obj) //api/resident/delete
        {
            dynamic resp = new ExpandoObject();
            resp.Success = Resident.deleteResident(Convert.ToInt32(obj.id));

            return resp;
        }

        [HttpPost]
        public dynamic get([FromBody] dynamic obj) //api/resident/get
        {
           
            string json = JsonConvert.SerializeObject(Resident.getResident(Convert.ToInt32(obj.id)));
            dynamic resp = JsonConvert.DeserializeObject(json);
            resp.Success = !(Resident.getResident(Convert.ToInt32(obj.id)) is null);
            return resp;          
        }

        [HttpPost]
        public dynamic getAll() //api/resident/getAll
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(Manager.viewAllResidents());
            resp.Success = true;
            return resp;
        }

    }
}