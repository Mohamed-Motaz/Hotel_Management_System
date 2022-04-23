using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractWorker : AbstractUser
    {
        public int salary { set; get; }
        public JobTitle jobTitle { set;  get; }
        public string incomeType { set;  get; }

        protected AbstractWorker(string userName, int age, string email, string phoneNumber, int salary, JobTitle jobTitle, string incomeType) : 
            base(userName, age, email, phoneNumber)
        {
            this.salary = salary;
            this.jobTitle = jobTitle;
            this.incomeType = incomeType;
        }

    }
}