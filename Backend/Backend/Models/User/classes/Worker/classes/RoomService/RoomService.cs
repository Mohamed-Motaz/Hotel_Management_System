using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class RoomService : AbstractWorker
    {
        public RoomService(string userName, int age, string email, string phoneNumber, int salary, JobTitle jobTitle, string incomeType) : 
            base(userName, age, email, phoneNumber, salary, jobTitle, incomeType) {}

    }
}