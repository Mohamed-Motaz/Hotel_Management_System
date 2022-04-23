using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class FullBoard : BoardingType 
    {
        public FullBoard()
        {
            this.id = 1;
            price = 1500;
            type = BoardingTypes.Full;
        }
    }
}