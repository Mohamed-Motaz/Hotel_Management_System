using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TripleRoom : Room
    {
        public TripleRoom(int id, RoomType type, double pricePerNight, Status status) :
            base(id, type, pricePerNight, status){ }
    }
}
