using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.BoardTypes
{
    public class HalfBoard : BoardingType
    {
        public HalfBoard()
        {
            this.id = 2;
            price = 1000;
            type = BoardingTypes.Half;
        }
    }
}