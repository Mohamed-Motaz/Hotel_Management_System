using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class ListRepositry : ContainerForIterator
    {
        List<Object> list = new List<object>();
        private Iterator iterator;
        public ListRepositry(List<Object>list)
        {
            this.list = list;
        }
        public override Iterator GetIterator()
        {
           iterator = new ListIterator(list);
           return iterator;
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