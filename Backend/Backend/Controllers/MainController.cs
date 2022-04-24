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
    
    public class MainController : ApiController
    {
        [HttpPost]
        public string signIn([FromBody] string json) //api/main/signIn
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.Type = UserAuthenticationServices.Signin(obj.userName, obj.password, obj.worker);
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

    }
}