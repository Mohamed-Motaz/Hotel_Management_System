using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class BookingInformation
    {
        public int id { get; set; }
        public int roomId { get; set; }
        public int boardId { get; set; }
        public int residentId { get; set; }
        public long startDate { get; set; }
        public long endDate { get; set; }
        public float totalPrice { get; set; }
    }
}