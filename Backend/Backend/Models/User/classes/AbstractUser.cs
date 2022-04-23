using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class AbstractUser
    {
        public static int UserIds = 1;
        public int id { set; get; }
        public string userName { set; get; }
        public int age { set; get; }
        public string email { set; get; }
        public string phoneNumber { set; get; }

        public AbstractUser(string userName, int age, string email, string phoneNumber)
        {
            id = UserIds++;
            this.userName = userName;
            this.age = age;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
 
    }
}