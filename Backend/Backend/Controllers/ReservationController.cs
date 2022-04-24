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
        public string builder([FromBody] string json) //api/reservation/builder    
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            List<object> singleRooms = RoomAndBoardingBuilder.GetSingleRoomBookings(obj.startDate, obj.endDate);
            List<object> doubleRooms = RoomAndBoardingBuilder.GetDoubleRoomBookings(obj.startDate, obj.endDate);
            doubleRooms.Concat(singleRooms);
            List<object> tripleRooms = RoomAndBoardingBuilder.GetTripleRoomBookings(obj.startDate, obj.endDate);
            doubleRooms.Concat(tripleRooms);
            obj.lst = new List<object>(doubleRooms);
            string res = JsonConvert.SerializeObject(obj);
            return res;
        }

        [HttpPost]
        public string add([FromBody] string json) //api/reservation/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            RoomAndBoarding roomAndBoarding = new RoomAndBoarding(obj.roomType,obj.boardingType);
            dynamic resp = new ExpandoObject();
            resp.TotalPrice = BookingServices.MakeBooking(roomAndBoarding, obj.startDate, obj.endDate, obj.residentId);
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

        [HttpPost]
        public string edit([FromBody] string json) //api/reservation/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Room room = RoomServices.GetRoomById(obj.roomId);
            BoardingType boardingType = BoardingTypesCache.GetBoardingType(obj.boardingType);
            BookingInformation booking = new BookingInformation(room, boardingType, obj.residentId, obj.startDate, obj.endDate);
            dynamic resp = new ExpandoObject();
            resp.TotalPrice = BookingServices.EditBooking(booking);
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

        [HttpPost]
        public string delete([FromBody] string json) //api/reservation/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.Success = BookingServices.deleteBooking(obj.id);
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

        [HttpPost]
        public string checkout([FromBody] string json) //api/reservation/checkout
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(Receptionist.checkOut(obj.roomId));
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }


        [HttpPost]
        public string get([FromBody] string json) //api/reservation/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetBookingInformations(obj.id));
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

        [HttpPost]
        public string getActive() //api/reservation/getActive
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetActiveBookingInformation());
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

        [HttpPost]
        public string getAll() //api/reservation/getAll
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetAllBookingInformation());
            string res = JsonConvert.SerializeObject(resp);
            return res;
        }

    }

}