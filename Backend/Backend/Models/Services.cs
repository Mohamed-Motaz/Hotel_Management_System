using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Services
    {
        public int MAX_SINGLE_ROOMS = 30;
        public int MAX_DOUBLE_ROOMS = 30;
        public int MAX_TRIPLE_ROOMS = 30;

        private Services(){ }

        private static Services services = null;

        public static Services getInstance() 
        {
            if (services == null) 
            {
                services = new Services();
            }
            return services;
        }


        public bool checkIfRoomAvailable(RoomType type)
        {
            bool isAvailable = false;

            if ( (type == RoomType.Single) && (MAX_SINGLE_ROOMS > 0) )
            {
                isAvailable = true;
            }
            else if ((type == RoomType.Double) && (MAX_DOUBLE_ROOMS > 0))
            {
                isAvailable = true;
            }
            else if ((type == RoomType.Triple) && (MAX_TRIPLE_ROOMS > 0))
            {
                isAvailable = true;
            }

            return isAvailable;
        }

        public void printDividor()
        {
            Console.WriteLine("==================================================================");
        }
    }
}
