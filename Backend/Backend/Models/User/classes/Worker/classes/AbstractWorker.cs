using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractWorker : AbstractUser
    {
        public int salary { set; get; }
        public string jobTitle { set;  get; }
        public string incomeType { set;  get; }

        protected AbstractWorker(string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType) : 
            base(userName, age, email, phoneNumber)
        {
            this.salary = salary;
            this.jobTitle = jobTitle;
            this.incomeType = incomeType;
        }

    }
}