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
            obj.Success = true;
            return obj;
        }

        [HttpPost]
        public dynamic add([FromBody] dynamic obj) //api/reservation/add
        {
            RoomAndBoarding roomAndBoarding = new RoomAndBoarding(Convert.ToString(obj.roomType), Convert.ToString(obj.boardingType));
            dynamic resp = new ExpandoObject();
            BookingInformation booking = BookingServices.MakeBooking(roomAndBoarding, Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate), Convert.ToInt32(obj.residentId));
            resp.TotalPrice = booking.totalPrice;
            resp.roomId = booking.roomId;
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic edit([FromBody] dynamic obj) //api/reservation/edit
        {
            Room room = RoomFactory.GetRoom(Convert.ToString(obj.roomType), Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate));
            dynamic resp = new ExpandoObject();
            if (room is null)
            {
                resp.Success = false;
                return resp;
            }
            BoardingType boardingType = BoardingTypesCache.GetBoardingType(Convert.ToString(obj.boardingType));
            BookingInformation editedBooking = new BookingInformation( room, boardingType, Convert.ToInt32(obj.residentId), Convert.ToInt64(obj.startDate), Convert.ToInt64(obj.endDate));
            BookingInformation booking = BookingServices.EditBooking(Convert.ToInt32(obj.id), editedBooking);
            resp.TotalPrice = booking.totalPrice;
            resp.roomId = booking.roomId;
            resp.Success = !(booking is null);
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
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic get([FromBody] dynamic obj) //api/reservation/get
        {
            dynamic resp = new ExpandoObject();
            BookingInformation bookingObject = BookingServices.GetBooking(Convert.ToInt32(obj.id));
            dynamic modifiedBooking = new ExpandoObject();
            modifiedBooking.id = bookingObject.id;
            modifiedBooking.roomId = bookingObject.roomId;
            modifiedBooking.residentId = bookingObject.residentId;
            modifiedBooking.startDate = bookingObject.startDate;
            modifiedBooking.endDate = bookingObject.endDate;
            modifiedBooking.roomType = RoomServices.GetRoomById(bookingObject.roomId).Type;
            modifiedBooking.boardingType = bookingObject.boardingType;
            modifiedBooking.totalPrice = bookingObject.totalPrice;

            resp.booking = bookingObject;
            resp.Success = !(bookingObject is null);
            return resp;
        }


        [HttpPost]
        public dynamic getResidentBookings([FromBody] dynamic obj) //api/reservation/getResidentBookings
        {
            dynamic resp = new ExpandoObject();
            List<object> bookingList = new List<object>(BookingServices.GetBookingInformations(Convert.ToInt32(obj.residentId)));
            List<object> modifiedBookingList = new List<object>();
            foreach (object booking in bookingList)
            {
                BookingInformation bookingObject = booking as BookingInformation;
                dynamic modifiedBooking = new ExpandoObject();
                modifiedBooking.id = bookingObject.id;
                modifiedBooking.roomId = bookingObject.roomId;
                modifiedBooking.residentId = bookingObject.residentId;
                modifiedBooking.startDate = bookingObject.startDate;
                modifiedBooking.endDate = bookingObject.endDate;
                modifiedBooking.roomType = RoomServices.GetRoomById(bookingObject.roomId).Type;
                modifiedBooking.boardingType = bookingObject.boardingType;
                modifiedBooking.totalPrice = bookingObject.totalPrice;
                modifiedBookingList.Add(modifiedBooking);
            }
            resp.lst = modifiedBookingList;
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic getActive() //api/reservation/getActive
        {
            dynamic resp = new ExpandoObject();
            List<object> bookingList = new List<object>(BookingServices.GetActiveBookingInformation());
            List<object> modifiedBookingList = new List<object>();
            foreach (object booking in bookingList)
            {
                BookingInformation bookingObject = booking as BookingInformation;
                dynamic modifiedBooking = new ExpandoObject();
                modifiedBooking.id = bookingObject.id;
                modifiedBooking.roomId = bookingObject.roomId;
                modifiedBooking.residentId = bookingObject.residentId;
                modifiedBooking.startDate = bookingObject.startDate;
                modifiedBooking.endDate = bookingObject.endDate;
                modifiedBooking.roomType = RoomServices.GetRoomById(bookingObject.roomId).Type;
                modifiedBooking.boardingType = bookingObject.boardingType;
                modifiedBooking.totalPrice = bookingObject.totalPrice;
                modifiedBookingList.Add(modifiedBooking);
            }
            resp.lst = modifiedBookingList;
            resp.Success = true;
            return resp;
        }

        [HttpPost]
        public dynamic getAll() //api/reservation/getAll
        {
            dynamic resp = new ExpandoObject();
            List<object> bookingList = new List<object>(BookingServices.GetAllBookingInformation());
            List<object> modifiedBookingList = new List<object>();
            foreach (object booking in bookingList)
            {
                BookingInformation bookingObject = booking as BookingInformation;
                dynamic modifiedBooking = new ExpandoObject();
                modifiedBooking.id = bookingObject.id;
                modifiedBooking.roomId = bookingObject.roomId;
                modifiedBooking.residentId = bookingObject.residentId;
                modifiedBooking.startDate = bookingObject.startDate;
                modifiedBooking.endDate = bookingObject.endDate;
                modifiedBooking.roomType = RoomServices.GetRoomById(bookingObject.roomId).Type;
                modifiedBooking.boardingType = bookingObject.boardingType;
                modifiedBooking.totalPrice = bookingObject.totalPrice;
                modifiedBookingList.Add(modifiedBooking);
            }
            resp.lst = modifiedBookingList; resp.Success = true;
            return resp;
        }

    }

}