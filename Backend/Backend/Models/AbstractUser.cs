using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class AbstractUser
    {
        protected int id;
        protected string userName;
        protected int age;
        protected string email;
        protected string phoneNumber;

        public AbstractUser(int id, string userName, int age, string email, string phoneNumber)
        {
            this.id = id;
            this.userName = userName;
            this.age = age;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public void setUserName(String userName)
        {
            this.userName = userName;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public void setMobileNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
 
    }
}