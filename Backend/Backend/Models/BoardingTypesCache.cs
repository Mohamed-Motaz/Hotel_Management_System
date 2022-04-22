using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.BoardTypes
{
    public class BoardingTypesCache
    {
        public static Dictionary<int, BoardingType> dict = new Dictionary<int, BoardingType>();
        public static void LoadCache()
        {
            FullBoard fullBoard = new FullBoard();
            dict.Add(fullBoard.id, fullBoard);

            HalfBoard halfBoard = new HalfBoard();
            dict.Add(halfBoard.id, halfBoard);

            BedAndBreakfast bedAndBreakfast = new BedAndBreakfast();
            dict.Add(bedAndBreakfast.id, bedAndBreakfast);
        }

        public static BoardingType GetBoardingType(int boardingTypeId)
        {
            return (BoardingType)dict.ElementAt(boardingTypeId).Value;
        }

    }
}