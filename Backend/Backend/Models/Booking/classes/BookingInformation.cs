using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class BookingInformation
    {
        public static int BookingIds = 1; 
        public int id { get; set; }
        public int roomId { get; set; }
        public string boardingType { get; set; }
        public int residentId { get; set; }
        public long startDate { get; set; }
        public long endDate { get; set; }
        public double totalPrice { get; set; }


        public BookingInformation(Room room, BoardingType boarding, int residentId, long startDate, long endDate)
        {
            roomId = room.Id;
            boardingType = boarding.type;
            this.residentId = residentId;
            this.startDate = startDate;
            this.endDate = endDate;
            totalPrice = BookingServices.GetBookingPrice(boarding, room,startDate,endDate); 
        }
    
    }

    
}