using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractBuilder
    {
        private BookingInformation Booking;
        public BookingInformation GetBookingInformation() { return Booking; }
        public void CreateNewBookingInformation() { Booking = new BookingInformation(); }
        public abstract void BuildBooking(RoomType roomType, BoardingType boardType);

    }
}







