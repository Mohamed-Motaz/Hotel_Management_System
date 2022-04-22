using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class DoubleRoom : Room
    {
        public DoubleRoom(int id, RoomType type, double pricePerNight, Status status) :
            base(id, type, pricePerNight, status){ }
    }
}
