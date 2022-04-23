using Backend;
using Backend.Models;
using System.Collections.Generic;

public static class RoomAndBoardBuilder
{

    public static List<RoomAndBoard> GetAvailableBookings(long startDate, long endDate)
    {
        List<RoomAndBoard> roomAndBoards = new List<RoomAndBoard>();

        RoomFactory roomFactory = new RoomFactory ();

        if (roomFactory.GetRoom(RoomTypes.Single,startDate,endDate) != null)
        {
            RoomAndBoard SingleAndFull = new RoomAndBoard();
            SingleAndFull.boardingType = BoardingTypes.Full;
            SingleAndFull.roomType = RoomTypes.Single;
            roomAndBoards.Add(SingleAndFull);
            RoomAndBoard SingleAndHalf = new RoomAndBoard();
            SingleAndHalf.boardingType = BoardingTypes.Half;
            SingleAndHalf.roomType = RoomTypes.Single;
            roomAndBoards.Add(SingleAndHalf);
            RoomAndBoard SingleAndBed = new RoomAndBoard();
            SingleAndBed.boardingType = BoardingTypes.BedAndBreakfast;
            SingleAndBed.roomType = RoomTypes.Single;
            roomAndBoards.Add(SingleAndBed);

        }
        if (roomFactory.GetRoom(RoomTypes.Double, startDate, endDate) != null)
        {
            RoomAndBoard DoubleAndFull = new RoomAndBoard();
            DoubleAndFull.boardingType = BoardingTypes.Full;
            DoubleAndFull.roomType = RoomTypes.Double;
            roomAndBoards.Add(DoubleAndFull);
            RoomAndBoard DoubleAndHalf = new RoomAndBoard();
            DoubleAndHalf.boardingType = BoardingTypes.Half;
            DoubleAndHalf.roomType = RoomTypes.Double;
            roomAndBoards.Add(DoubleAndHalf);
            RoomAndBoard DoubleAndBed = new RoomAndBoard();
            DoubleAndBed.boardingType = BoardingTypes.BedAndBreakfast;
            DoubleAndBed.roomType = RoomTypes.Double;
            roomAndBoards.Add(DoubleAndBed);
        }
        if (roomFactory.GetRoom(RoomTypes.Triple, startDate, endDate) != null)
        { 
            RoomAndBoard TripleAndFull = new RoomAndBoard();
            TripleAndFull.boardingType = BoardingTypes.Full;
            TripleAndFull.roomType = RoomTypes.Triple;
            roomAndBoards.Add(TripleAndFull);
            RoomAndBoard TripleAndHalf = new RoomAndBoard();
            TripleAndHalf.boardingType = BoardingTypes.Half;
            TripleAndHalf.roomType = RoomTypes.Triple;
            roomAndBoards.Add(TripleAndHalf);
            RoomAndBoard TripleAndBed = new RoomAndBoard();
            TripleAndBed.boardingType = BoardingTypes.BedAndBreakfast;
            TripleAndBed.roomType = RoomTypes.Triple;
            roomAndBoards.Add(TripleAndBed);
        }

        return roomAndBoards;
    }

}