using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class BoardingType : ICloneable
    { 
    
        public int id { get; set; } 
        public int price { get; set; }
        public BoardingTypes type { get; set; }


        public object Clone()
        {
            Object newType = null;
            try
            {
                newType = base.MemberwiseClone();

            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine( new System.Diagnostics.StackTrace() );
            }
            return newType;
        }
    }
}