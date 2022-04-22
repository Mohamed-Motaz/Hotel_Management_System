using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class BookingInformation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int BoardId { get; set; }
        public int ResidentId { get; set; }
        public long StartDate { get; set; }
        public long NumOfNights { get; set; }
        public float TotalPrice { get; set; }

    }
}