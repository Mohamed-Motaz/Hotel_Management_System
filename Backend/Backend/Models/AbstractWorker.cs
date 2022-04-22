﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractWorker: AbstractUser
    {
        private int salary;
        public string jobTitle; 
        public string incomeType;

        // operations
        void setSalary(int salary)
        {
            this.salary = salary;
        }
        void setJobTitle(string jobTitle)
        {
            this.jobTitle = jobTitle;
        }
        void setIncomeType(string incomeType)
        {
            this.incomeType = incomeType;
        }

    }
}