using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractWorker : AbstractUser
    {
        private int salary;
        public string jobTitle; 
        public string incomeType;

        protected AbstractWorker(int id, string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType) : base(id, userName, age, email, phoneNumber)
        {
            this.salary = salary;
            this.jobTitle = jobTitle;
            this.incomeType = incomeType;
        }

        // operations
        int getSalary(int salary)
        {
            return salary;
        }
        string getJobTitle(string jobTitle)
        {
            return jobTitle;
        }
        string getIncomeType(string incomeType)
        {
            return incomeType;
        }

    }
}