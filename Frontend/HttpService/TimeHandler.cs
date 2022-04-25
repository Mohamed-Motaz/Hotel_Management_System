using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.HttpService
{
    class TimeHandler
    {

        public static string GetDateFromEpoch(long epoch)
        {
            return (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).AddSeconds(epoch)).ToShortDateString();
        }

        public static long GetDateInEpoch(int day, int month, int year)
        {
            return (long)(new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero) - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
        }

    }
}
