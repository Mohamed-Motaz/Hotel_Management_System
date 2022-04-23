using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class ListRepositry : ContainerForIterator
    {
        public List<object> list = new List<object>();
        private Iterator iterator;
        public override Iterator GetIterator()
        {
            iterator = new ListIterator(list);
            return iterator;
        }

    }
}