using Backend.Models;
using Backend.Models.BoardTypes;
using Backend.Models.Rooms;
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

    public class ReservationController : ApiController
    {

        [HttpPost]
        public dynamic builder([FromBody] string json) //api/reservation/builder    
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            List<object> singleRooms = RoomAndBoardingBuilder.GetSingleRoomBookings(obj.startDate, obj.endDate);
            List<object> doubleRooms = RoomAndBoardingBuilder.GetDoubleRoomBookings(obj.startDate, obj.endDate);
            List<object> tripleRooms = RoomAndBoardingBuilder.GetTripleRoomBookings(obj.startDate, obj.endDate);
            obj.singleRooms = singleRooms;
            obj.doubleRooms = doubleRooms;
            obj.tripleRooms = tripleRooms;


            return obj;
        }

        [HttpPost]
        public dynamic add([FromBody] string json) //api/reservation/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            RoomAndBoarding roomAndBoarding = new RoomAndBoarding(obj.roomType,obj.boardingType);
            dynamic resp = new ExpandoObject();
            resp.TotalPrice = BookingServices.MakeBooking(roomAndBoarding, obj.startDate, obj.endDate, obj.residentId);
            
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] string json) //api/reservation/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Room room = RoomServices.GetRoomById(obj.roomId);
            BoardingType boardingType = BoardingTypesCache.GetBoardingType(obj.boardingType);
            BookingInformation booking = new BookingInformation(room, boardingType, obj.residentId, obj.startDate, obj.endDate);
            dynamic resp = new ExpandoObject();
            resp.TotalPrice = BookingServices.EditBooking(booking);
            
            return resp;
        }

        [HttpPost]
        public dynamic delete([FromBody] string json) //api/reservation/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.Success = BookingServices.deleteBooking(obj.id);
            
            return resp;
        }

        [HttpPost]
        public dynamic checkout([FromBody] string json) //api/reservation/checkout
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(Receptionist.checkOut(obj.roomId));
            
            return resp;
        }


        [HttpPost]
        public dynamic get([FromBody] string json) //api/reservation/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetBookingInformations(obj.id));
            
            return resp;
        }

        [HttpPost]
        public dynamic getActive() //api/reservation/getActive
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetActiveBookingInformation());
            
            return resp;
        }

        [HttpPost]
        public dynamic getAll() //api/reservation/getAll
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetAllBookingInformation());
            
            return resp;
        }

    }

}