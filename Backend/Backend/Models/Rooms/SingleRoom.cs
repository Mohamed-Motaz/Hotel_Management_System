﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    class SingleRoom : Room
    {
        public SingleRoom(int id, RoomTypes type, double pricePerNight, RoomStatus status) : 
            base(id, type, pricePerNight, status){}
    }
}
