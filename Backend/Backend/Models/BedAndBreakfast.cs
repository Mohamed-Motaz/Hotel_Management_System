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
            setId(3);
            setPrice(500);
            setType(3);
        }
    }
}