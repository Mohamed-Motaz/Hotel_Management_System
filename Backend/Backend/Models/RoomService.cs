using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class RoomService : AbstractWorker
    {
        public RoomService(int id, string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType) : 
            base(id, userName, age, email, phoneNumber, salary, jobTitle, incomeType) {}
        // operations

    }
}