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

    public class ManagerController : ApiController
    {

        [HttpPost]
        public dynamic dashboard() //api/manager/dashboard
        {
            dynamic resp = new ExpandoObject();
            resp.newResidents = Resident.getTodayResidents();
            resp.currentResidents = Resident.getCurrentResidents();
            List<object> workers = Manager.viewAllWorkers();
            resp.numOfWorkers = workers.Count;
            resp.weeklyIncome = Manager.getIncome(Duration.Weekly);
            resp.monthlyIncome = Manager.getIncome(Duration.Monthly);
            resp.yearlyIncome = Manager.getIncome(Duration.Yearly);
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic getIncome() //api/manager/getIncome
        {
            dynamic resp = new ExpandoObject();
            resp.weeklyIncome = Manager.getIncome(Duration.Weekly);
            resp.monthlyIncome = Manager.getIncome(Duration.Monthly);
            resp.yearlyIncome = Manager.getIncome(Duration.Yearly);
            resp.Success = true;
            return resp;
        }



    }
}