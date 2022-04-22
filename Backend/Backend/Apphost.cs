using Backend.Models;
using Backend.Models.BoardTypes;
using Backend.Models.Loggers;
using Backend.Models.Rooms;
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

        public static ListRepositry ListOfResidents = new ListRepositry();
        public static ListRepositry ListOfPrivilegedWorkers = new ListRepositry();
        public static ListRepositry ListOfRoomServices = new ListRepositry();
        public static ListRepositry ListOfBookingInformation = new ListRepositry();
        public static ListRepositry ListOfAvailableRooms = new ListRepositry();
        public static ListRepositry ListOfReservedRooms = new ListRepositry();

        private static Logger GetChainOfLoggers()
        {
            Logger fileLogger = new FileLogger(Logger.FileLogger);
            Logger consoleLogger = new ConsoleLogger(Logger.ConsoleLogger);
            consoleLogger.SetNextLogger(fileLogger);
            return consoleLogger;
        }
        public static void InitializeAllRooms()
        {
            int NumberOfRoom = 0;
            for(int room = 0; room < 90; room++)
            {
                if (room < 30)
                {
                    ListOfAvailableRooms.list.Add((Room)new SingleRoom(
                            100 + NumberOfRoom,
                            RoomTypes.Single,
                            2700,
                            RoomStatus.Available
                        ));
                }
                else if (room < 60 && room >= 30)
                {
                    ListOfAvailableRooms.list.Add((Room)new SingleRoom(
                            100 + NumberOfRoom,
                            RoomTypes.Double,
                            2700,
                            RoomStatus.Available
                        ));
                }
                else if (room < 90 && room >= 60)
                {
                    ListOfAvailableRooms.list.Add((Room)new SingleRoom(
                            100 + NumberOfRoom,
                            RoomTypes.Triple,
                            2700,
                            RoomStatus.Available
                        ));
                }
                NumberOfRoom %= 30;
            }
        }
        public static void InitializeApp()
        {
            logger = GetChainOfLoggers();
            BoardingTypesCache.LoadCache();
            InitializeAllRooms();
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

    public enum RoomStatus
    {
        Reserved, 
        Available
    }

}