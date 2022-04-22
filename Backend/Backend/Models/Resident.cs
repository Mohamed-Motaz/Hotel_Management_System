using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Resident : AbstractUser
    {
        private string password;

        public Resident(int id, string userName, int age, string email, string phoneNumber, string password) :
            base(id, userName, age, email, phoneNumber) 
        {
            this.password = password;
        }
       
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