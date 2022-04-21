using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Resident: AbstractUser
    {
        private string password;

        BookingInformation GetBooking(int residentID)
        {
            BookingInformation details = new BookingInformation();
            // some operations to get 
            return details;
        }
        // GetRoom(int roomID)
        // GetRoomServices(int roomID)

    }
}