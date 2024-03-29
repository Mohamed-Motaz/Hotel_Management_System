﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Resident : User
    {
        public string password;

        public Resident(string userName, int age, string email, string phoneNumber, string password) :
            base(userName, age, email, phoneNumber) 
        {
            this.password = password;
        }

        public bool EditResident(int oldId,Resident editedResident)
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident resident = ResidentsIterator.getNext() as Resident;
                if (oldId == resident.id)
                {
                    resident.userName = editedResident.userName;
                    resident.phoneNumber = editedResident.phoneNumber;
                    resident.password = editedResident.password;
                    resident.email = editedResident.email;
                    resident.age = editedResident.age;
                    return true;
                }
            }
            return false;
        }
        public bool AddResident(Resident resident)
        {
            if (UserAuthenticationServices.isUserNameFound(resident.userName)) return false;
            Apphost.ListOfResidents.list.Add(resident);
            return true;
        }

        public static Resident getResident(int id)
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident resident = ResidentsIterator.getNext() as Resident;
                if (id == resident.id)
                {
                    return resident;
                }
            }
            return null;
        }

        public static int getResidentByUserName(string userName)
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident resident = ResidentsIterator.getNext() as Resident;
                if (userName == resident.userName)
                {
                    return resident.id;
                }
            }
            return -1;
        }


        public static bool deleteResident(int id)
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident resident = ResidentsIterator.getNext() as Resident;
                if (id == resident.id)
                {
                    Apphost.ListOfResidents.list.Remove(resident);
                    return true;
                }
            }
            return false;
        }

        public static int getTodayResidents()
        {
            TimeHandler timeHandler = TimeHandler.getInstance();

            HashSet<int> residents = new HashSet<int>();
            for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
            {
                BookingInformation booking = bookingIterator.getNext() as BookingInformation;

                if (booking.startDate == timeHandler.GetTodayInEpoch())
                {
                    residents.Add(booking.residentId);
                }
            }
            return residents.Count;
        }

        public static int getCurrentResidents()
        {
            TimeHandler timeHandler = TimeHandler.getInstance();
            HashSet<int> residents = new HashSet<int>();
            for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
            {
                BookingInformation booking = bookingIterator.getNext() as BookingInformation;

                if (booking.endDate > timeHandler.GetTodayInEpoch())
                {
                    residents.Add(booking.residentId);
                }
            }
            return residents.Count;
        }

    }
}