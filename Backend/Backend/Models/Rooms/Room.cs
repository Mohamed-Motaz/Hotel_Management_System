using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum Status{ Reserved, NotReserved }
    enum RoomType{ Single, Double, Triple }

    

    abstract class Room
    {

        public int Id;
        public RoomType type;
        public double pricePerNight;
        public Status status;

        public Room(int id, RoomType type, double pricePerNight, Status status) {
            this.Id = id;
            this.type = type;
            this.pricePerNight = pricePerNight;
            this.status = status;
        }

        public virtual String showRoomInfo() 
        {
            return "Room #"+Id+":\n"
                +"Type: "+type+"\n"
                +"Price Per Night: " + pricePerNight + "\n"
                +"Status: " + status + "\n";
        }

    }
}
