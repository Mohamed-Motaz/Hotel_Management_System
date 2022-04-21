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
            setId(1);
            setPrice(1500);
            setType(1);
        }
    }
}