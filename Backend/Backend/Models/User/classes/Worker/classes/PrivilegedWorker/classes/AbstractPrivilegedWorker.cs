using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractPrivilegedWorker : AbstractWorker
    {
        public string password;
        protected AbstractPrivilegedWorker(string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType, string password) :
            base(userName, age, email, phoneNumber, salary, jobTitle, incomeType)
        {
            this.password = password;
        }
        
    }
}