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

    public class WorkerController : ApiController
    {


        [HttpPost]
        public string add(string json) //api/worker/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            AbstractWorker worker;
            if (obj.jobTitle == JobTitle.RoomService)
            {
                worker = new RoomService(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.Title, obj.incomeType);
            }
            else if (obj.jobTitle == JobTitle.Receptionist)
            {
                worker = new Receptionist(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.Title, obj.incomeType, obj.password);
            }
            else
            {
                worker = new Manager(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.Title, obj.incomeType, obj.password);
            }
            Manager.addWorker(worker, obj.password);
            string res = JsonConvert.SerializeObject(true);
            return res;
        }

        [HttpPost]
        public string edit(string json) //api/worker/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            AbstractWorker worker;
            if (obj.jobTitle == JobTitle.RoomService)
            {
                worker = new RoomService(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.Title, obj.incomeType);
            }
            else if(obj.jobTitle == JobTitle.Receptionist)
            {
                worker = new Receptionist(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.Title, obj.incomeType, obj.password);
            }
            else
            {
                worker = new Manager(obj.username, obj.age, obj.email, obj.phoneNumber, obj.salary, obj.Title, obj.incomeType, obj.password);
            }
            Manager.editWorker(worker, obj.password);
            string res = JsonConvert.SerializeObject(true);
            return res;
        }

        [HttpPost]
        public string get(string json) //api/worker/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            string res = JsonConvert.SerializeObject(Manager.getWorker(obj.id));
            return res;
        }

        [HttpPost]
        public string delete(string json) //api/worker/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Manager.deleteWorker(obj.id);
            string res = JsonConvert.SerializeObject(true);
            return res;
        }

        [HttpPost]
        public string getAll(string json) //api/worker/getAll
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            string res = JsonConvert.SerializeObject(Manager.viewAllWorkers());
            return res;
        }

    }
}