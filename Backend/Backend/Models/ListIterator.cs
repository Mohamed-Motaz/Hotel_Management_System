using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class ListIterator : Iterator
    {
        int curIndex = 0;
        ListCreate list;
        public ListIterator(ListCreate list)
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
            if (curIndex < list.length() - 1)
            {
               next = list[++curIndex];
            }
            return next;
        }

        public override bool hasNext()
        {
            return curIndex + 1 < list.length();
        
        }
    }
}