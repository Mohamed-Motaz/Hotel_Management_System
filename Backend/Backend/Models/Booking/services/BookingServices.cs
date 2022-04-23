using Backend.Models;
using Backend.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Text;

public static class BookingServices
{

    public static double GetBookingPrice(BoardingType board, Room room, long startDate, long endDate)
    {
        return (room.PricePerNight + board.price) * TimeHandler.GetNumberOfDays(startDate, endDate);
    }

}