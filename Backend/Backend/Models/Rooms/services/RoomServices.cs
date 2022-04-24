using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    class RoomServices
    {

        public static bool CheckIfRoomAvailable(Room room, long startDate, long endDate)
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

        public static Room GetRoomById(int roomId)
        {
            for (Iterator roomIterator = Apphost.ListOfRooms.GetIterator(); roomIterator.hasNext();)
            {
                Room room = roomIterator.getNext() as Room;
                if (room.Id == roomId)
                {
                    return room;
                }
            }
            return null;
        }

        public static List<object> GetReservedRooms()
        {
            List<object> reservedRooms = new List<object>();

            for (Iterator roomIterator = Apphost.ListOfRooms.GetIterator(); roomIterator.hasNext();)
            {
                Room room = roomIterator.getNext() as Room;
                if (!CheckIfRoomAvailable(room, TimeHandler.GetTodayInEpoch(), TimeHandler.GetTodayInEpoch()))
                {
                    reservedRooms.Add(room);
                }
            }
            return reservedRooms;
        }

        public static List<object> GetAvailableRooms()
        {
            List<object> availableRooms = new List<object>();

            for (Iterator roomIterator = Apphost.ListOfRooms.GetIterator(); roomIterator.hasNext();)
            {
                Room room = roomIterator.getNext() as Room;
                if (CheckIfRoomAvailable(room, TimeHandler.GetTodayInEpoch(), TimeHandler.GetTodayInEpoch()))
                {
                    availableRooms.Add(room);
                }
            }
            return availableRooms;
        }


        public static List<object> GetAllRooms()
        {
            return Apphost.ListOfRooms.list;
        }

    }
}
