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
            setId(2);
            setPrice(1000);
            setType(2);
        }
    }
}