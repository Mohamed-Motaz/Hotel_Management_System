using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    class RoomFactory
    {
        private RoomServices myServices = RoomServices.GetInstance();

        public Room GetRoom(RoomTypes type)
        {
            if (!myServices.CheckIfRoomTypeAvailable(type))
            {
                return null;
            }

            for (Iterator roomIterator = Apphost.ListOfAvailableRooms.GetIterator(); roomIterator.hasNext();)
            {
                Room room = roomIterator.getNext() as Room;
                if (room.Type == type)
                {
                    myServices.ChangeRoomStatus(room);
                    return room;
                }
            }
            return null;
        }
    } 
}
