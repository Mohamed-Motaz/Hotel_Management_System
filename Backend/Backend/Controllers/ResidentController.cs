using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace Backend.Controllers
{
    
    public class ResidentController : ApiController
    {
        [Route("api/resident/signIn")]
        public bool Post([FromBody]string userName, [FromBody] string password, [FromBody] bool worker)
        {
            return UserAuthenticationServices.Signin(userName,password,worker);
        }

        
    }
}
