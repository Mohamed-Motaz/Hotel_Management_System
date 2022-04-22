using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class ListCreate
    {
        List<Object> list = new List<object>();
        public Iterator createListIterator()
        {
            return new ListIterator(this);
        }
        public int length()
        {
            return list.Count;
        }
        public void add(Object obj)
        {
            list.Add(obj);
        }
        public void delete(Object obj)
        {
            list.Remove(obj);
        }
        public object this[int index]
        {
            get { return list[index]; }
            set { list[index]= value; }
        }
    }
}