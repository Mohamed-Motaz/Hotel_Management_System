using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class ContainerForIterator
    {
        public abstract Iterator GetIterator();
    }
}