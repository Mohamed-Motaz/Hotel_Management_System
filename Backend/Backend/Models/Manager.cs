﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Manager : AbstractPrivilegedWorker
    {
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
            if (typeOfUsers.ToLower()=="workers")
            {

            }
            else if (typeOfUsers.ToLower() == "redidents")
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