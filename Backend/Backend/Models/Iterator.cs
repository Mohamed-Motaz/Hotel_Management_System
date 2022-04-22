using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class Iterator
    {
        public abstract object getFirst();
        public abstract object getNext();
        public abstract bool hasNext();
        public abstract object currentItem();
    }
}