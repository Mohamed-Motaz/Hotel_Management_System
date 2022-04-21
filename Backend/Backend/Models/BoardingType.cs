using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class BoardingType : ICloneable
    { 
    
        protected int id, price;
        protected int type;
        public int getId(){ return id;  }
        public void setId(int id) {  this.id = id;}
        public int getPrice(){return price; }
        public void setPrice(int price) {  this.price = price; }
        public int getType() {  return type; }
        public void setType(int type) {   this.type = type;  }


        public object Clone()
        {
            Object newType = null;
            try
            {
                newType = base.MemberwiseClone();
            }catch(NotSupportedException ex)
            {
                Console.WriteLine( new System.Diagnostics.StackTrace() );
            }
            return newType;
        }
    }
}