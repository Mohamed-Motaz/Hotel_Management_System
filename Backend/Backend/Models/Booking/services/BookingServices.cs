using Backend;
using Backend.Models;
using Backend.Models.BoardTypes;
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
    //TODO take care when calling the below method
    public static double MakeBooking(RoomAndBoarding bookingDetails, long startDate, long endDate, int residentId)
    {
        RoomFactory factory = new RoomFactory();
        Room room = factory.GetRoom(bookingDetails.roomType, startDate, endDate);
        BoardingType board = BoardingTypesCache.GetBoardingType(bookingDetails.boardingType);
        BookingInformation bookingInformation = new BookingInformation(room, board, residentId, startDate, endDate);
        Apphost.ListOfBookingInformation.list.Add(bookingInformation);
        return bookingInformation.totalPrice;
    }

    public static double EditBooking(BookingInformation editedBooking)
    {
        BookingInformation oldBooking = null;
        for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
        {
            BookingInformation booking = bookingIterator.getNext() as BookingInformation;
            if (booking.id == editedBooking.id)
                oldBooking = booking;
            
        }

        long nowInEpoch = TimeHandler.GetDateInEpoch(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);

        if (oldBooking.startDate < nowInEpoch)  //booking period has started
        {
            double oldPrice = GetBookingPrice(BoardingTypesCache.GetBoardingType(oldBooking.boardingType), Room.getRoomById(oldBooking.roomId), oldBooking.startDate, nowInEpoch);
            double newPrice = GetBookingPrice(BoardingTypesCache.GetBoardingType(editedBooking.boardingType), Room.getRoomById(editedBooking.roomId), nowInEpoch, editedBooking.endDate);
            editedBooking.totalPrice = newPrice + oldPrice;
        }
        Apphost.ListOfBookingInformation.list.Remove(oldBooking);
        Apphost.ListOfBookingInformation.list.Add(editedBooking);
        return editedBooking.totalPrice;
    }

    public static List<object> GetBookingInformations(int residentId)
    {
        List<object> bookingInformations = new List<object>();

        for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
        {
            BookingInformation booking = bookingIterator.getNext() as BookingInformation;
            if (booking.residentId == residentId)
            {
                bookingInformations.Add(booking);
            }
        }
        return bookingInformations;
    }

    public static List<object> GetAllBookingInformation()
    {
        return Apphost.ListOfBookingInformation.list;
    }  
    
    public static bool deleteBooking(int id)
    {

        for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
        {
            BookingInformation booking = bookingIterator.getNext() as BookingInformation;
            if (id == booking.id)
            {
                DateTime now = DateTime.Now;
                if (booking.startDate < TimeHandler.GetDateInEpoch(now.Day, now.Month, now.Year))
                {
                    return false;
                }
                Apphost.ListOfBookingInformation.list.Remove(booking);
                return true;
            }

        }
        return false;
    }
    

}