using Backend.Models.BoardTypes;
using Backend.Models.Loggers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Backend
{


    public static class Apphost
    { 

        //global variables
        public static Logger logger;

        public static string CUR_DIRECTORY = AppDomain.CurrentDomain.BaseDirectory;
        public static string DB_PATH = Path.Combine(CUR_DIRECTORY, "db.sqlite");


        public static int MAX_SINGLE_ROOMS = 30;
        public static int MAX_DOUBLE_ROOMS = 30;
        public static int MAX_TRIPLE_ROOMS = 30;

        public static int CURR_SINGLE_ROOMS = 0;
        public static int CURR_DOUBLE_ROOMS = 0;
        public static int CURR_TRIPLE_ROOMS = 0;

        private static Logger GetChainOfLoggers()
        {
            Logger fileLogger = new FileLogger(Logger.FileLogger);
            Logger consoleLogger = new ConsoleLogger(Logger.ConsoleLogger);
            consoleLogger.SetNextLogger(fileLogger);
            return consoleLogger;
        }

        public static void InitializeApp()
        {
            logger = GetChainOfLoggers();
            BoardingTypesCache.LoadCache();
        }

    }

   

    public enum RoomTypes
    {
        Single,
        Double,
        Triple
    }

    public enum BoardingTypes
    {
        Full,
        Half,
        BedAndBreakfast
    }

}