using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class AbstractUser
    {
        public int id { set; get; }
        public string userName { set; get; }
        public int age { set; get; }
        public string email { set; get; }
        public string phoneNumber { set; get; }

        public AbstractUser(int id, string userName, int age, string email, string phoneNumber)
        {
            this.id = id;
            this.userName = userName;
            this.age = age;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
 
    }
}