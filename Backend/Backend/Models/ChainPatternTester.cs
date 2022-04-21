using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.Loggers
{
    public class ChainPatternTester
    {
        private static Logger getChainOfLoggers()
        {
            Logger fileLogger = new FileLogger(Logger.Debug);
            Logger consoleLogger = new ConsoleLogger(Logger.Info);

            consoleLogger.setNextLogger(fileLogger);

            return consoleLogger;

        }
        public static void test()
        {
            Logger loggerChain = getChainOfLoggers();
            loggerChain.logMessages(Logger.Info, "This is an info");
            loggerChain.logMessages(Logger.Debug, "This is an debug");
            loggerChain.logMessages(Logger.Error, "This is an error");
        }
    }

}