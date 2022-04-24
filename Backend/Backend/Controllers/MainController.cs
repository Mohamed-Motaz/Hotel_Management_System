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
        public dynamic signIn([FromBody] dynamic obj) //api/main/signIn
        {
            dynamic resp = new ExpandoObject();
            resp.Type = UserAuthenticationServices.Signin(Convert.ToString(obj.username), Convert.ToString(obj.password), Convert.ToBoolean(obj.worker));
            return resp;
        }

    }
}