using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Resident : AbstractUser
    {
        private string password;

        public Resident(string userName, int age, string email, string phoneNumber, string password) :
            base(userName, age, email, phoneNumber) 
        {
            this.password = password;
        }

        
        //sign up
        //sign in
        //edit information
        //change password
        //get all reservations
        //make reservation
        //edit reservation
        //cancel reservation
        


    }
}