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

        public static ListRepositry ListOfResidents = new ListRepositry();
        public static ListRepositry ListOfPrivilegedWorkers = new ListRepositry();
        public static ListRepositry ListOfRoomServices = new ListRepositry();
        public static ListRepositry ListOfBookingInformation = new ListRepositry();
        public static ListRepositry ListOfRooms = new ListRepositry();

        private static Logger GetChainOfLoggers()
        {
            Logger fileLogger = new FileLogger(Logger.FileLogger);
            Logger consoleLogger = new ConsoleLogger(Logger.ConsoleLogger);
            consoleLogger.SetNextLogger(fileLogger);
            return consoleLogger;
        }
        public static void InitializeAllRooms()
        {
            for(int room = 0; room < 90; room++)
            {
                if (room < 30)
                {
                    ListOfRooms.list.Add((Room)new SingleRoom(
                            RoomTypes.Single,
                            2700,
                            RoomStatus.Available
                        ));
                }
                else if (room < 60 && room >= 30)
                {
                    ListOfRooms.list.Add((Room)new DoubleRoom(
                            RoomTypes.Double,
                            4000,
                            RoomStatus.Available
                        ));
                }
                else if (room < 90 && room >= 60)
                {
                    ListOfRooms.list.Add((Room)new TripleRoom(
                            RoomTypes.Triple,
                            4800,
                            RoomStatus.Available
                        ));
                }
            }
        }
        public static void InitializeApp()
        {
            logger = GetChainOfLoggers();
            BoardingTypesCache.LoadCache();
            InitializeAllRooms();
        }
    }

    public enum JobTitle
    {
        Manager,
        Receptionist,
        RoomService
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

    public enum Duration
    {
        Weekly,
        Monthly,
        Annualy
    }

}