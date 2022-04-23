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
    
    public class MainController : ApiController
    {
        [HttpPost]
        public string signIn(string json) //api/main/signIn
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            string res = JsonConvert.SerializeObject(UserAuthenticationServices.Signin(obj.userName, obj.password, obj.worker));
            return res;
        }
        
    }
}