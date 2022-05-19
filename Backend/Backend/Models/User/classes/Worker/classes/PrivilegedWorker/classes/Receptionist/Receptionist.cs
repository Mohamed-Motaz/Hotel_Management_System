using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Receptionist : PrivilegedWorker
    {
        public Receptionist(string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType, string password) :
            base(userName, age, email, phoneNumber, salary, jobTitle, incomeType, password) { }


        public static double checkOut(int roomId)
        {
            TimeHandler timeHandler = TimeHandler.getInstance();
            for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
            {
                BookingInformation booking = bookingIterator.getNext() as BookingInformation;
                if (booking.roomId == roomId)
                {
                    booking.endDate = timeHandler.GetDateInEpoch(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
                    BookingServices.EditBooking(booking.id,booking);
                    return booking.totalPrice;
                }
            }
            return -1;
        }
    }
}