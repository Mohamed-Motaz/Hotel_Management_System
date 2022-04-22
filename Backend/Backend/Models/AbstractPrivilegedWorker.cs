using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractPrivilegedWorker : AbstractWorker
    {
        private string password;

        protected AbstractPrivilegedWorker(int id, string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType, string password) : base(id, userName, age, email, phoneNumber, salary, jobTitle, incomeType)
        {
            this.password = password;
        }
        bool signIn(string name, string password, string typeOfUser)
        {
            // type of user -> Manager or Receptionist
          
            return false;
        }
        // for manager can add a worker, while receptionist can add resident
        public abstract void addUser(AbstractUser newUser);
        public abstract void editUser(AbstractUser user);
        public abstract void deleteUser(AbstractUser user);
    }
}