using Backend.Models;
using Backend.Models.BoardTypes;
using Backend.Models.Rooms;
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

    public class ReservationController : ApiController
    {

        [HttpPost]
        public string builder(string json) //api/reservation/builder    
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
        public string add(string json) //api/reservation/add
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            RoomAndBoarding roomAndBoarding = new RoomAndBoarding(obj.roomType,obj.boardingType);
            string res = JsonConvert.SerializeObject(BookingServices.MakeBooking(roomAndBoarding, obj.startDate, obj.endDate, obj.residentId));
            return res;
        }

        [HttpPost]
        public string edit(string json) //api/reservation/edit
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            Room room = RoomServices.GetInstance().GetRoomById(obj.roomId);
            BoardingType boardingType = BoardingTypesCache.GetBoardingType(obj.boardingType);
            BookingInformation booking = new BookingInformation(room, boardingType, obj.residentId, obj.startDate, obj.endDate);
            string res = JsonConvert.SerializeObject(BookingServices.EditBooking(booking));
            return res;
        }

        [HttpPost]
        public string delete(string json) //api/reservation/delete
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            string res = JsonConvert.SerializeObject(BookingServices.deleteBooking(obj.id));
            return res;
        }

        [HttpPost]
        public string checkout(string json) //api/reservation/checkout
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            obj.lst = new List<object>(Receptionist.checkOut(obj.roomId));
            string res = JsonConvert.SerializeObject(obj);
            return res;
        }


        [HttpPost]
        public string get(string json) //api/reservation/get
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            obj.lst = new List<object>(BookingServices.GetBookingInformations(obj.id));
            string res = JsonConvert.SerializeObject(obj);
            return res;
        }

        [HttpPost]
        public string getActive(string json) //api/reservation/getActive
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            obj.lst = new List<object>(BookingServices.GetActiveBookingInformation());
            string res = JsonConvert.SerializeObject(obj);
            return res;
        }

        [HttpPost]
        public string getAll(string json) //api/reservation/getAll
        {
            dynamic obj = JsonConvert.DeserializeObject(json);
            obj.lst = new List<object>(BookingServices.GetAllBookingInformation());
            string res = JsonConvert.SerializeObject(obj);
            return res;
        }

    }

}