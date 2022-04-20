using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class BookingInformation
    {
        private int id;
        private int roomId;
        private int boardId;
        private int residentId;
        private long startDate;
        private long endDate;
        private float totalPrice;
    }
}