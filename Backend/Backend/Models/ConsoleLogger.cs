using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.Loggers
{
    public class ConsoleLogger : Logger
    {

        public ConsoleLogger(int level)
        {
            this.level = level;
        }
        public override void write(string messages)
        {
            Console.WriteLine("This is a console message : " + messages);
        }
    }
}