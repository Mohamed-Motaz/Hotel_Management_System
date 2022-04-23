using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class SingleRoom : Room
    {
        public SingleRoom(RoomTypes type, double pricePerNight, RoomStatus status) : 
            base(type, pricePerNight, status){}
    }
}
