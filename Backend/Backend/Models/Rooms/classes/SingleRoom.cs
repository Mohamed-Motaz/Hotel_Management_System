using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class SingleRoom : Room
    {
        public SingleRoom(string type, double pricePerNight, string status) : 
            base(type, pricePerNight, status){}
    }
}
