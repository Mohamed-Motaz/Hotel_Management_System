using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    
    abstract class Room
    {

        public int Id { get; set; }
        public RoomType Type { get; set; }
        public double PricePerNight { get; set; }
        public RoomStatus Status { get; set; }

        public Room(int id, RoomType type, double pricePerNight, RoomStatus status) {
            this.Id = id;
            this.Type = type;
            this.PricePerNight = pricePerNight;
            this.Status = status;
        }

        public virtual String ShowRoomInfo() 
        {
            return "Room #"+Id+":\n"
                +"Type: "+Type+"\n"
                +"Price Per Night: " + RricePerNight + "\n"
                +"Status: " + Status + "\n";
        }

    }
}
