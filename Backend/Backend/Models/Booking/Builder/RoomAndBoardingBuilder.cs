using Backend;
using Backend.Models;
using System.Collections.Generic;

public static class RoomAndBoardingBuilder
{

    public static List<RoomAndBoarding> GetSingleRoomBookings(long startDate, long endDate)
    {
        List<RoomAndBoarding> RoomAndBoardings = new List<RoomAndBoarding>();

        if (!(RoomFactory.GetRoom(RoomTypes.Single,startDate,endDate) is null))
        {
            RoomAndBoarding SingleAndFull = new RoomAndBoarding();
            SingleAndFull.boardingType = BoardingTypes.Full;
            SingleAndFull.roomType = RoomTypes.Single;
            RoomAndBoardings.Add(SingleAndFull);
            RoomAndBoarding SingleAndHalf = new RoomAndBoarding();
            SingleAndHalf.boardingType = BoardingTypes.Half;
            SingleAndHalf.roomType = RoomTypes.Single;
            RoomAndBoardings.Add(SingleAndHalf);
            RoomAndBoarding SingleAndBed = new RoomAndBoarding();
            SingleAndBed.boardingType = BoardingTypes.BedAndBreakfast;
            SingleAndBed.roomType = RoomTypes.Single;
            RoomAndBoardings.Add(SingleAndBed);

        }
        return RoomAndBoardings;
    }

    public static List<RoomAndBoarding> GetDoubleRoomBookings(long startDate, long endDate)
    {
        List<RoomAndBoarding> RoomAndBoardings = new List<RoomAndBoarding>();

        if (!(RoomFactory.GetRoom(RoomTypes.Double, startDate, endDate) is null))
        {
            RoomAndBoarding DoubleAndFull = new RoomAndBoarding();
            DoubleAndFull.boardingType = BoardingTypes.Full;
            DoubleAndFull.roomType = RoomTypes.Double;
            RoomAndBoardings.Add(DoubleAndFull);
            RoomAndBoarding DoubleAndHalf = new RoomAndBoarding();
            DoubleAndHalf.boardingType = BoardingTypes.Half;
            DoubleAndHalf.roomType = RoomTypes.Double;
            RoomAndBoardings.Add(DoubleAndHalf);
            RoomAndBoarding DoubleAndBed = new RoomAndBoarding();
            DoubleAndBed.boardingType = BoardingTypes.BedAndBreakfast;
            DoubleAndBed.roomType = RoomTypes.Double;
            RoomAndBoardings.Add(DoubleAndBed);
        }
        return RoomAndBoardings;
    }

    public static List<RoomAndBoarding> GetTripleRoomBookings(long startDate, long endDate)
    {
        List<RoomAndBoarding> RoomAndBoardings = new List<RoomAndBoarding>();

        if (!(RoomFactory.GetRoom(RoomTypes.Triple, startDate, endDate) is null))
        {
            RoomAndBoarding TripleAndFull = new RoomAndBoarding();
            TripleAndFull.boardingType = BoardingTypes.Full;
            TripleAndFull.roomType = RoomTypes.Triple;
            RoomAndBoardings.Add(TripleAndFull);
            RoomAndBoarding TripleAndHalf = new RoomAndBoarding();
            TripleAndHalf.boardingType = BoardingTypes.Half;
            TripleAndHalf.roomType = RoomTypes.Triple;
            RoomAndBoardings.Add(TripleAndHalf);
            RoomAndBoarding TripleAndBed = new RoomAndBoarding();
            TripleAndBed.boardingType = BoardingTypes.BedAndBreakfast;
            TripleAndBed.roomType = RoomTypes.Triple;
            RoomAndBoardings.Add(TripleAndBed);
        }

        return RoomAndBoardings;
    }

}