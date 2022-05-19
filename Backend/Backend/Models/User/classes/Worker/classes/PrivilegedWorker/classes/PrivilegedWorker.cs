using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class PrivilegedWorker : Worker
    {
        public string password;
        protected PrivilegedWorker(string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType, string password) :
            base(userName, age, email, phoneNumber, salary, jobTitle, incomeType)
        {
            this.password = password;
        }
        
    }
}