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
        public override void Write(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}