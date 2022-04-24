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

    public class WorkerController : ApiController
    {

        [HttpPost]
        public dynamic add([FromBody]string json) //api/worker/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            AbstractWorker worker;
            if (obj.jobTitle == JobTitle.RoomService)
            {
                worker = new RoomService(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.jobTitle, obj.incomeType);
            }
            else if (obj.jobTitle == JobTitle.Receptionist)
            {
                worker = new Receptionist(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.jobTitle, obj.incomeType, obj.password);
            }
            else
            {
                worker = new Manager(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.jobTitle, obj.incomeType, obj.password);
            }
            Manager.addWorker(worker, obj.password);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] string json) //api/worker/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            AbstractWorker worker;
            if (obj.jobTitle == JobTitle.RoomService)
            {
                worker = new RoomService(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.jobTitle, obj.incomeType);
            }
            else if(obj.jobTitle == JobTitle.Receptionist)
            {
                worker = new Receptionist(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.jobTitle, obj.incomeType, obj.password);
            }
            else
            {
                worker = new Manager(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.jobTitle, obj.incomeType, obj.password);
            }
            Manager.editWorker(worker, obj.password);
            dynamic resp = new ExpandoObject();
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic delete([FromBody] string json) //api/worker/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Manager.deleteWorker(obj.id);
            dynamic resp = new ExpandoObject();
            resp.Success = true;

            return resp;
        }

        [HttpPost]
        public dynamic get([FromBody] string json) //api/worker/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = JsonConvert.DeserializeObject(Manager.getWorker(obj.id));
            return resp;
        }

        [HttpPost]
        public dynamic getAll() //api/worker/getAll
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(Manager.viewAllWorkers());
            return resp;
        }

    }
}