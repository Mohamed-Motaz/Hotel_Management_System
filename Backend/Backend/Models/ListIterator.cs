using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class ListIterator : Iterator
    {
        int curIndex = 0;
        List<object> list;
        public ListIterator(List<object> list)
        {
            this.list = list;
        }

        public override object currentItem()
        {
            return list[curIndex];
        }

        public override object getFirst()
        {
            return list[0];
        }

        public override object getNext()
        {
            object next = null;
            if (this.hasNext())
            {
               next = list[curIndex++];
            }
            return next;
        }

        public override bool hasNext()
        {
            return curIndex < list.Count;
        }
    }
}