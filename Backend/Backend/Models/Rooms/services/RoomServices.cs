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


        public bool CheckIfRoomTypeAvailable(RoomTypes type)
        {
            if ((type == RoomTypes.Single) && (Apphost.CURR_SINGLE_ROOMS < Apphost.MAX_SINGLE_ROOMS))
                return true;

            if ((type == RoomTypes.Double) && (Apphost.CURR_DOUBLE_ROOMS < Apphost.MAX_DOUBLE_ROOMS))
                return true;

            if ((type == RoomTypes.Triple) && (Apphost.CURR_TRIPLE_ROOMS < Apphost.MAX_TRIPLE_ROOMS))
                return true;

            return false;
        }

        public void ChangeRoomStatus(Room room)
        {
            Apphost.ListOfReservedRooms.list.Add(room);
            Apphost.ListOfAvailableRooms.list.Remove(room);
            if (room.Type == RoomTypes.Single) Apphost.CURR_SINGLE_ROOMS++;

            else if (room.Type == RoomTypes.Double) Apphost.CURR_DOUBLE_ROOMS++;

            else if (room.Type == RoomTypes.Triple) Apphost.CURR_TRIPLE_ROOMS++;

        }


        public void PrintDividor()
        {
            Console.WriteLine("==================================================================");
        }
    }
}
