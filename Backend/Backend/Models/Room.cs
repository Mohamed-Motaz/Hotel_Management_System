using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class Room
    {
        private int id;
        private string type;
        private float pricePerNight;
        private string status;
    }
}