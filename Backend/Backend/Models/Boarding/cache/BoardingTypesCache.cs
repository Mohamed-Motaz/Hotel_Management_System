using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.BoardTypes
{
    public class BoardingTypesCache
    {
        public static Dictionary<string, BoardingType> dict = new Dictionary<string, BoardingType>();
        public static void LoadCache()
        {
            FullBoard fullBoard = new FullBoard();
            dict.Add(fullBoard.type, fullBoard);

            HalfBoard halfBoard = new HalfBoard();
            dict.Add(halfBoard.type, halfBoard);

            BedAndBreakfast bedAndBreakfast = new BedAndBreakfast();
            dict.Add(bedAndBreakfast.type, bedAndBreakfast);
        }

        public static BoardingType GetBoardingType(string boardingType)
        {
            return (BoardingType)dict[boardingType].Clone();
        }

    }
}