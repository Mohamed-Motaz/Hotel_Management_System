using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Models
{
    class Services
    {
        private Services(){ }

        private static Services services = null;

        public static Services GetInstance() 
        {
            if (services == null) 
            {
                services = new Services();
            }
            return services;
        }


        public bool CheckIfRoomAvailable(RoomTypes type)
        {
            if ((type == RoomTypes.Single) && (Apphost.CURR_SINGLE_ROOMS < Apphost.MAX_SINGLE_ROOMS))
                return true;

            if ((type == RoomTypes.Double) && (Apphost.CURR_DOUBLE_ROOMS < Apphost.MAX_DOUBLE_ROOMS))
                return true;

            if ((type == RoomTypes.Triple) && (Apphost.CURR_TRIPLE_ROOMS < Apphost.MAX_TRIPLE_ROOMS))
                return true;

            return false;
        }

        public void PrintDividor()
        {
            Console.WriteLine("==================================================================");
        }
    }
}
