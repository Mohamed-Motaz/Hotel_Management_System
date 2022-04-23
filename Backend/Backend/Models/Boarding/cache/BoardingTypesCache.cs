using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.BoardTypes
{
    public class BoardingTypesCache
    {
        public static Dictionary<BoardingTypes, BoardingType> dict = new Dictionary<BoardingTypes, BoardingType>();
        public static void LoadCache()
        {
            FullBoard fullBoard = new FullBoard();
            dict.Add(fullBoard.type, fullBoard);

            HalfBoard halfBoard = new HalfBoard();
            dict.Add(halfBoard.type, halfBoard);

            BedAndBreakfast bedAndBreakfast = new BedAndBreakfast();
            dict.Add(bedAndBreakfast.type, bedAndBreakfast);
        }

        public static BoardingType GetBoardingType(BoardingTypes boardingType)
        {
            return (BoardingType)dict[boardingType];
        }

    }
}