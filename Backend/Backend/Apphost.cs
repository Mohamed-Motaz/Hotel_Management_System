using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Backend
{
    public class Apphost
    {
        public static string DB_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.sqlite");

        public static int MAX_SINGLE_ROOMS = 30;
        public static int MAX_DOUBLE_ROOMS = 30;
        public static int MAX_TRIPLE_ROOMS = 30;

        public static int CURR_SINGLE_ROOMS = 0;
        public static int CURR_DOUBLE_ROOMS = 0;
        public static int CURR_TRIPLE_ROOMS = 0;

    }

    public enum RoomType
    {
        Single,
        Double,
        Triple
    }

    public enum BoardingType
    {
        Full,
        Hald,
        BedAndBreakfast
    }
}