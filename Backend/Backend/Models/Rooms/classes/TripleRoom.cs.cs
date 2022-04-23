using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class TripleRoom : Room
    {
        public TripleRoom(RoomTypes type, double pricePerNight, RoomStatus status) :
            base(type, pricePerNight, status){ }
    }
}
