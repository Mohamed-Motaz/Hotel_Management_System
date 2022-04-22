using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SingleRoom : Room
    {
        public SingleRoom(int id, RoomType type, double pricePerNight, Status status) : 
            base(id, type, pricePerNight, status){}
    }
}
