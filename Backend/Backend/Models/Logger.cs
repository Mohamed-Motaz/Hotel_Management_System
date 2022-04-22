using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.Loggers
{
    public abstract class Logger
    {
        public static int ConsoleLogger = 1 ;
        public static int FileLogger = 2;

        protected int level;

        private Logger nextLogger;

        public void SetNextLogger(Logger NextLogger)
        {
            nextLogger = NextLogger;
        }
        public void LogMessages(int level, string message)
        {
            if (this.level <= level)
                Write(message);
            if (nextLogger != null)
                nextLogger.LogMessages(level, message);
        }

        public abstract void Write(string messages);
    }
}