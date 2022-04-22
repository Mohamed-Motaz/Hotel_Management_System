using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    class RoomFactory
    {
        private Services myServices = Services.GetInstance();
        //TODO, add and remove from iterator object
        public Room GetRoom(RoomTypes type)
        {
            if(type == RoomTypes.Single)
            {
                if(myServices.CheckIfRoomAvailable(type)) 
                {
                    Apphost.CURR_SINGLE_ROOMS++;
                    return new SingleRoom(
                        100 + Apphost.CURR_SINGLE_ROOMS,
                        RoomTypes.Single,
                        2700,
                        RoomStatus.Reserved
                    );
                }
                else
                    return null;
            }

            if (type == RoomTypes.Double)
            {
                if (myServices.CheckIfRoomAvailable(type))
                {
                    Apphost.CURR_DOUBLE_ROOMS++;
                    return new DoubleRoom(
                        200 + Apphost.CURR_DOUBLE_ROOMS,
                        RoomTypes.Double,
                        4000,
                        RoomStatus.Reserved
                    );
                }
                else
                    return null;
            }
            if (type == RoomTypes.Triple)
            {
                if (myServices.CheckIfRoomAvailable(type))
                {
                    Apphost.CURR_TRIPLE_ROOMS++;
                    return new TripleRoom(
                        200 + Apphost.CURR_TRIPLE_ROOMS,
                        RoomTypes.Triple,
                        4800,
                        RoomStatus.Reserved
                    );
                }
                else
                    return null;
            }

            return null;
        }
    }
}
