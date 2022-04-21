using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.Loggers
{
    public abstract class Logger
    {
        public static int Info = 1 ;
        public static int Debug = 2;
        public static int Error = 3;
        protected int level;

        protected Logger nextLogger;

        public void setNextLogger(Logger NextLogger)
        {
            nextLogger = NextLogger;
        }
        public void logMessages(int level, string message)
        {
            if (this.level <= level)
                write(message);
            if (nextLogger != null)
                nextLogger.logMessages(level, message);
        }

        abstract public void write(string messages);
    }
}