using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models.Rooms
{
    
    public abstract class Room
    {

        public static int roomsIds = 1;
        public int Id { get; set; }
        public RoomTypes Type { get; set; }
        public double PricePerNight { get; set; }
        public RoomStatus Status { get; set; }

        public Room(RoomTypes type, double pricePerNight, RoomStatus status) {
            this.Id = roomsIds++;
            this.Type = type;
            this.PricePerNight = pricePerNight;
            this.Status = status;
        }

        public virtual String ShowRoomInfo() 
        {
            return "Room #"+Id+":\n"
                +"Type: "+Type+"\n"
                +"Price Per Night: " + PricePerNight + "\n"
                +"Status: " + Status + "\n";
        }

        public static Room getRoomById(int id)
        {
            for (Iterator roomIterator = Apphost.ListOfRooms.GetIterator(); roomIterator.hasNext();)
            {
                Room room = roomIterator.getNext() as Room;
                if (room.Id == id)
                {
                    return room;
                }
            }
            return null;
        }

    }
}
