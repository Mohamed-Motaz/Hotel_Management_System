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

    public class RoomController : ApiController
    {
        [HttpPost]
        public dynamic getAvailable() //api/room/getActive
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(RoomServices.GetAvailableRooms());
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic getReserved() //api/room/getBusy
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(RoomServices.GetReservedRooms());
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic getAll() //api/room/getAll
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(RoomServices.GetAllRooms());
            resp.Success = true;
            return resp;
        }



    }
}