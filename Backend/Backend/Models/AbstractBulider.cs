using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractBulider
    {
        BookingInformation Booking;
        public BookingInformation getBookingInformation() { return Booking; }
        public void CreateNewBookingInformation() { Booking = new BookingInformation(); }
        public abstract void bulidbooking(RoomType roomType, BoardingType boardType);

    }
}







