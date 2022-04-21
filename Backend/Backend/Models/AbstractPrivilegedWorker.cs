using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public abstract class AbstractPrivilegedWorker: AbstractWorker
    {
        private int password;
        void signIn()
        {

        }
        // for manager can add a worker, while receptionist can add resident
        public abstract void addUser(AbstractUser newUser);
        public abstract void editUser(AbstractUser user);
        public abstract void deleteUser(AbstractUser user);
    }
}