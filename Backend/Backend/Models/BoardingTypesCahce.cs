using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models.BoardTypes
{
    public class BoardingTypesCahce
    {
        public static Dictionary<int, BoardingType> dict = new Dictionary<int, BoardingType>();
        public static void loadCache()
        {
            FullBoard fullBoard = new FullBoard();
            dict.Add(fullBoard.getId(), fullBoard);

            HalfBoard halfBoard = new HalfBoard();
            dict.Add(halfBoard.getId(), halfBoard);

            BedAndBreakfast bedAndBreakfast = new BedAndBreakfast();
            dict.Add(bedAndBreakfast.getId(), bedAndBreakfast);
        }

        public static BoardingType GetBoardingType(int boardingTypeId)
        {
            return (BoardingType)dict.ElementAt(boardingTypeId).Value;
        }

    }
}