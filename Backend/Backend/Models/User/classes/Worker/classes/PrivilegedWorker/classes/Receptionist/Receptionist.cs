using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Receptionist : AbstractPrivilegedWorker
    {
        public Receptionist(string userName, int age, string email, string phoneNumber, int salary, JobTitle jobTitle, string incomeType, string password) :
            base(userName, age, email, phoneNumber, salary, jobTitle, incomeType, password) { }


        public double checkOut(BookingInformation booking)
        {
            booking.endDate = TimeHandler.GetDateInEpoch(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            BookingServices.EditBooking(booking);
            return booking.totalPrice;
        }

    }
}