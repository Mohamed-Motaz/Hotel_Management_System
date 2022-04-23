using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Manager : AbstractPrivilegedWorker
    {
        public Manager(string userName, int age, string email, string phoneNumber, int salary, JobTitle jobTitle, string incomeType, string password) : 
            base(userName, age, email, phoneNumber, salary, jobTitle, incomeType, password) {}

        public void addWorker(AbstractWorker newWorker, string password)
        {
            if(newWorker.jobTitle == JobTitle.Receptionist)
            {
                Receptionist receptionist = new Receptionist(newWorker.userName,newWorker.age,newWorker.email,newWorker.phoneNumber,newWorker.salary,newWorker.jobTitle,newWorker.incomeType, password);
                Apphost.ListOfPrivilegedWorkers.list.Add(receptionist);
            }
            else if(newWorker.jobTitle == JobTitle.Manager)
            {
                Manager manager = new Manager(newWorker.userName, newWorker.age, newWorker.email, newWorker.phoneNumber, newWorker.salary, newWorker.jobTitle, newWorker.incomeType, password);
                Apphost.ListOfPrivilegedWorkers.list.Add(manager);
            }
            else
            {
                RoomService roomService = (RoomService) newWorker;
                Apphost.ListOfRoomServices.list.Add(roomService);
            }
        }

        public void deleteWorker(AbstractWorker worker)
        {
            if(worker.jobTitle == JobTitle.RoomService)
            {
                Apphost.ListOfRoomServices.list.Remove(worker);
            }
            else
            {
                Apphost.ListOfPrivilegedWorkers.list.Remove(worker);
            }
        }

        public void editWorker(AbstractWorker editedWorker, string password)
        {
            if (editedWorker.jobTitle == JobTitle.RoomService)
            {
                for (Iterator workerIterator = Apphost.ListOfRoomServices.GetIterator(); workerIterator.hasNext();)
                {
                    RoomService worker = workerIterator.getNext() as RoomService;
                    if (worker.id == editedWorker.id)
                    {
                        worker = (RoomService)editedWorker;
                    }
                }
            }
            else
            {
                for (Iterator workerIterator = Apphost.ListOfPrivilegedWorkers.GetIterator(); workerIterator.hasNext();)
                {
                    AbstractPrivilegedWorker worker = workerIterator.getNext() as AbstractPrivilegedWorker;
                    if (worker.id == editedWorker.id)
                    {
                        worker = (AbstractPrivilegedWorker)editedWorker;
                    }
                }
            }
        }

        public List<object> viewAllWorkers()
        {
            return (List<object>)Apphost.ListOfRoomServices.list.Concat(Apphost.ListOfPrivilegedWorkers.list);
        }
        public List<object> viewAllResidents()
        {

            return Apphost.ListOfResidents.list;  
        }
        public double getIncome(Duration duration)
        {
            long targetedDuration;
            double totalIncome = 0;
            
            if(duration == Duration.Weekly)
            {
                targetedDuration = TimeHandler.GetLastWeekInEpoch();
            }
            else if(duration == Duration.Monthly)
            {
                targetedDuration = TimeHandler.GetLastMonthInEpoch();
            }
            else
            {
                targetedDuration=TimeHandler.GetLastYearInEpoch();
            }

            for (Iterator bookingIterator = Apphost.ListOfBookingInformation.GetIterator(); bookingIterator.hasNext();)
            {
                BookingInformation booking = bookingIterator.getNext() as BookingInformation;
                
                if (booking.endDate <= targetedDuration)
                {
                    totalIncome += booking.totalPrice;
                }
            }

            return totalIncome;
        }

        public List<object> showDetailsOfAllRooms(string typeOfTheRoom)
        {
            return Apphost.ListOfRooms.list;
        }

    }
}