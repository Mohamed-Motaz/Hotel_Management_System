using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    public class RoomFactory
    {

        public static Room GetRoom(string type, long startDate,long endDate)
        {
            for (Iterator roomIterator = Apphost.ListOfRooms.GetIterator(); roomIterator.hasNext();)
            {
                Room room = roomIterator.getNext() as Room;
                if (room.Type == type && RoomServices.CheckIfRoomAvailable(room, startDate, endDate))
                {
                    return room;
                }
            }
            return null;
        }
    } 
}
