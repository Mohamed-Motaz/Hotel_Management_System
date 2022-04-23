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
                Receptionist receptionist = new Receptionist(newWorker.userName,newWorker.age,newWorker.email,newWorker.salary,newWorker.incomeType, password);
            }
            else
            {

            }
        }

        public void deleteWorker(AbstractUser worker)
        {
       
        }

        public void editWorker(AbstractUser worker)
        {
     
        }

        public List<object> viewAllWorkers()
        {
            return Apphost.ListOfRoomServices.list.Concat(Apphost.ListOfPrivilegedWorkers.list;
        }
        public List<object> viewAllResidents()
        {
            return Apphost.ListOfResidents.list;  
        }
        private string getIncomeInfo(string duration)
        {
            string inCome = "";
            if(duration != null)
            {
                inCome = duration;
            }
            return inCome;
        }

        void showDetailsOfAllRooms(string typeOfTheRoom)
        {

        }

    }
}