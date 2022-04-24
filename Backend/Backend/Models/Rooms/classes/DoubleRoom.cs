using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class DoubleRoom : Room
    {
        public DoubleRoom(string type, double pricePerNight, string status) :
            base(type, pricePerNight, status){ }
    }
}
