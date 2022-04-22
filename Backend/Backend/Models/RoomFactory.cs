using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    class RoomFactory
    {
        Services myServices = Services.getInstance();

        public Room getRoom(RoomType type)
        {
            Room room = null;

            if(type == RoomType.Single)
            {
                if(myServices.checkIfRoomAvailable(type)) 
                {
                    room = new SingleRoom(
                        100 + myServices.MAX_SINGLE_ROOMS,
                        RoomType.Single,
                        2700,
                        Status.Reserved
                    );
                    myServices.MAX_SINGLE_ROOMS--;
                }
            }
            else if (type == RoomType.Double)
            {
                if (myServices.checkIfRoomAvailable(type))
                {
                    room = new DoubleRoom(
                        200 + myServices.MAX_DOUBLE_ROOMS,
                        RoomType.Double,
                        4000,
                        Status.Reserved
                    );
                    myServices.MAX_DOUBLE_ROOMS--;
                }
            }
            else
            {
                if (myServices.checkIfRoomAvailable(type))
                {
                    room = new TripleRoom(
                        200 + myServices.MAX_DOUBLE_ROOMS,
                        RoomType.Triple,
                        4800,
                        Status.Reserved
                    );
                    myServices.MAX_TRIPLE_ROOMS--;
                }
            }

            return room;
        }
    }
}
