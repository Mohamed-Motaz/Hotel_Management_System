using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.BoardTypes
{
    public class BedAndBreakfast : BoardingType
    {
        public BedAndBreakfast()
        {
            this.id = 3;
            price = 500;
            type = BoardingTypes.BedAndBreakfast;
        }
    }
}