using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{

    public class BookingBulider : AbstractBulider
    {

        public override void bulidbooking(RoomType roomType, BoardingType boardType)
        {
            Booking.roomtype = roomType;
            Booking.boardtype = boardType;
        }
    }
}

