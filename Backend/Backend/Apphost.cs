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
            for (int room = 1; room <= 6; room++)
            {
                if (room <= 2)
                {
                    ListOfRooms.list.Add((Room)new SingleRoom(
                            RoomTypes.Single,
                            2700,
                            RoomStatus.Available
                        ));
                }
                else if (room <= 4 && room > 2)
                {
                    ListOfRooms.list.Add((Room)new DoubleRoom(
                            RoomTypes.Double,
                            4000,
                            RoomStatus.Available
                        ));
                }
                else if (room <= 6 && room > 4)
                {
                    ListOfRooms.list.Add((Room)new TripleRoom(
                            RoomTypes.Triple,
                            4800,
                            RoomStatus.Available
                        ));
                }
            }
        }

        private static void InitializeFakeData()
        {
            TimeHandler timeHandler = TimeHandler.getInstance();
            ListOfBookingInformation.list = new List<object>()
            {
              /*  new BookingInformation(ListOfRooms.list[0] as Room, BoardingTypesCache.GetBoardingType(BoardingTypes.Full), 1, timeHandler.GetLastWeekInEpoch(), timeHandler.GetLastWeekInEpoch() + 3600 * 24),
                new BookingInformation(ListOfRooms.list[33] as Room, BoardingTypesCache.GetBoardingType(BoardingTypes.Half), 2, timeHandler.GetLastWeekInEpoch(), timeHandler.GetLastWeekInEpoch() + 3600 * 24),
                new BookingInformation(ListOfRooms.list[63] as Room, BoardingTypesCache.GetBoardingType(BoardingTypes.BedAndBreakfast), 3, timeHandler.GetLastWeekInEpoch(), timeHandler.GetLastWeekInEpoch() + 3600 * 24),


                new BookingInformation(ListOfRooms.list[0] as Room, BoardingTypesCache.GetBoardingType(BoardingTypes.Full), 1, timeHandler.GetLastWeekInEpoch(), timeHandler.GetTodayInEpoch() + 10000000),
                new BookingInformation(ListOfRooms.list[33] as Room, BoardingTypesCache.GetBoardingType(BoardingTypes.Half), 2, timeHandler.GetLastWeekInEpoch(), timeHandler.GetTodayInEpoch() + 10000000),
                new BookingInformation(ListOfRooms.list[63] as Room, BoardingTypesCache.GetBoardingType(BoardingTypes.BedAndBreakfast), 3, timeHandler.GetLastWeekInEpoch(), timeHandler.GetTodayInEpoch() + 100000)*/
            };

            ListOfRoomServices.list = new List<object>()
            {
                new RoomService("Salma", 21, "salma@gmail.com", "01119944415", 5000, JobTitle.RoomService, "Monthly" ),
                new RoomService("Rawan", 21, "rawan@gmail.com", "01119944415", 6000, JobTitle.RoomService , "Weekly"),
                new RoomService("Kareem", 21, "kareem@gmail.com", "01119944415", 15000, JobTitle.RoomService, "Yearly" )

            };

            ListOfResidents.list = new List<object>()
            {
                new Resident("resident", 22, "resident@", "01119944415", "1"),
                new Resident("ali", 22, "aliagina@", "01119944415", "1122334455"),
                new Resident("moatez", 23, "mohamedmoatez@", "01119944415", "112233664488"),
                new Resident("Rawan", 24, "Rawan@", "01119944415", "112231116688000"),

            };

            ListOfPrivilegedWorkers.list = new List<object> {
                new Manager("manager", 55, "manager@gmail.com", "01119944415", 30000, JobTitle.Manager, "Weekly", "1"),
                new Manager("Hossam El-Dien", 55, "hossam.eldien@gmail.com", "011192839924", 30000, JobTitle.Manager, "Weekly", "Hossam123"),
                new Manager("Sshraf Sherien", 40, "ashraf.sherien@gmail.com", "011134343466", 20000, JobTitle.Manager, "Monthly", "Ashraf123"),
                new Manager("Ahmed Fouda", 43, "ahmed.fouda@gmail.com", "011166090988", 15000, JobTitle.Manager, "Weekly", "Ahmed123"),
                
                new Receptionist("receptionist", 26, "receptionist@gmail.com", "01004999911", 10000, JobTitle.Receptionist, "Monthly", "1"),
                new Receptionist("Mostafa Hussien", 27, "mostafa.hussien@gmail.com", "01004999999", 10000, JobTitle.Receptionist, "Weekly", "Mostafa123"),
                new Receptionist("Mona Yasser", 25, "mona.yasser@gmail.com", "01004993399", 10000, JobTitle.Receptionist, "Monthly", "Mona123"),
                new Receptionist("Salma Amin", 26, "salma.amin@gmail.com", "01004999911", 10000, JobTitle.Receptionist, "Monthly", "Salma123"),
            };

        }

        public static void InitializeApp()
        {
            logger = GetChainOfLoggers();
            BoardingTypesCache.LoadCache();
            InitializeAllRooms();
            InitializeFakeData();
        }
    }

    public struct JobTitle
    {
        public static string Manager = "Manager";
        public static string Receptionist = "Receptionist";
        public static string RoomService = "Room Service";
    }

    public struct RoomTypes
    {
        public static string Single = "Single Room";
        public static string Double = "Double Room";
        public static string Triple = "Triple Room";
    }

    public struct BoardingTypes
    {
        public static string Full = "Full Board";
        public static string Half = "Half Board";
        public static string BedAndBreakfast = "BedAndBreakfast Board";
    }

    public struct RoomStatus
    {
        public static string Reserved = "Reserved";
        public static string Available = "Available";
    }

    public struct Duration
    {
        public static string Weekly = "Weekly";
        public static string Monthly = "Monthly";
        public static string Yearly = "Yearly";
    }

}