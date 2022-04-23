using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class DoubleRoom : Room
    {
        public DoubleRoom(RoomTypes type, double pricePerNight, RoomStatus status) :
            base(type, pricePerNight, status){ }
    }
}
