using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Receptionist : AbstractPrivilegedWorker
    {
        private string password;

        public Receptionist(string userName, int age, string email, int salary, string incomeType, string password)
        {
            this.userName = userName;
            this.age = age;
            this.email = email;
            this.salary = salary;
            this.incomeType = incomeType;
            this.password = password;
        }

        ////public Receptionist(string userName, int age, string email, string phoneNumber, int salary, JobTitle jobTitle, string incomeType, string password) :
          //  base(userName, age, email, phoneNumber, salary, jobTitle, incomeType, password) { }

    }
}