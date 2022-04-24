using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class TripleRoom : Room
    {
        public TripleRoom(string type, double pricePerNight, string status) :
            base(type, pricePerNight, status){ }
    }
}
