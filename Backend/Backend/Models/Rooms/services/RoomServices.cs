using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    class RoomServices
    {
        private RoomServices(){ }

        private static RoomServices services = null;

        public static RoomServices GetInstance() 
        {
            if (services == null) 
            {
                services = new RoomServices();
            }
            return services;
        }

        //todo rage3 ya mo3taz 3ashan dema3'y lafet -bedo
        public bool CheckIfRoomAvailable(Room room, long startDate, long endDate)
        {
            for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
            {
                BookingInformation booking = bookingIterator.getNext() as BookingInformation;
                if (booking.roomId == room.Id)
                {
                    if((booking.startDate <= startDate && booking.endDate >= startDate) || (booking.startDate <= endDate && booking.endDate >= endDate) || (booking.startDate >= startDate && booking.endDate <= endDate))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

       
    }
}
