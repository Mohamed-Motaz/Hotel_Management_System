using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Manager : AbstractPrivilegedWorker
    {
        public Manager(int id, string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType, string password) : 
            base(id, userName, age, email, phoneNumber, salary, jobTitle, incomeType, password) {}

        public override void addUser(AbstractUser newWorker)
        {
     
        }

        public override void deleteUser(AbstractUser worker)
        {
       
        }

        public override void editUser(AbstractUser worker)
        {
     
        }

        // users are workers and residents
        protected void viewAllUsersInfo(string typeOfUsers)
        {
            if (typeOfUsers.ToLower().Equals("workers"))
            {

            }
            else if (typeOfUsers.ToLower().Equals("residents"))
            {

            }
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