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
        public dynamic builder([FromBody] dynamic obj) //api/reservation/builder    
        {
            List<RoomAndBoarding> singleRooms = RoomAndBoardingBuilder.GetSingleRoomBookings(Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate));
            List<RoomAndBoarding> doubleRooms = RoomAndBoardingBuilder.GetDoubleRoomBookings(Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate));
            List<RoomAndBoarding> tripleRooms = RoomAndBoardingBuilder.GetTripleRoomBookings(Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate));

            List<RoomAndBoarding> mixedRooms = singleRooms
                .Concat(doubleRooms)
                .Concat(tripleRooms)
                .ToList();
            obj = new ExpandoObject();
            obj.lst = mixedRooms;
            return obj;
        }

        [HttpPost]
        public dynamic add([FromBody] dynamic obj) //api/reservation/add
        {
            RoomAndBoarding roomAndBoarding = new RoomAndBoarding(Convert.ToString(obj.roomType), Convert.ToString(obj.boardingType));
            dynamic resp = new ExpandoObject();
            resp.TotalPrice = BookingServices.MakeBooking(roomAndBoarding, Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate), Convert.ToInt32(obj.residentId));         
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] dynamic obj) //api/reservation/edit
        {
            Room room = RoomServices.GetRoomById(Convert.ToInt32(obj.roomId));
            BoardingType boardingType = BoardingTypesCache.GetBoardingType(Convert.ToString(obj.boardingType));
            BookingInformation booking = new BookingInformation(room, boardingType, Convert.ToInt32(obj.residentId), Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate));
            dynamic resp = new ExpandoObject();
            resp.TotalPrice = BookingServices.EditBooking(booking);
            return resp;
        }

        [HttpPost]
        public dynamic delete([FromBody] dynamic obj) //api/reservation/delete
        {
            dynamic resp = new ExpandoObject();
            resp.Success = BookingServices.deleteBooking(Convert.ToInt32(obj.id));
            
            return resp;
        }

        [HttpPost]
        public dynamic checkout([FromBody] dynamic obj) //api/reservation/checkout
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(Receptionist.checkOut(Convert.ToInt32(obj.roomId)));           
            return resp;
        }


        [HttpPost]
        public dynamic get([FromBody] dynamic obj) //api/reservation/get
        {
            dynamic resp = new ExpandoObject();
            resp.lst = new List<object>(BookingServices.GetBookingInformations(Convert.ToInt32(obj.residentId)));         
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