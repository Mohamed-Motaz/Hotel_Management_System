using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Receptionist : AbstractPrivilegedWorker
    {
        ListCreate listOfResidents = new ListCreate();
        public override void addUser(AbstractUser newUser)
        {
            listOfResidents.add(newUser);
        }
        public override void deleteUser(AbstractUser user)
        {
            listOfResidents.delete(user);
        }
        public override void editUser(AbstractUser user)
        {
            
        }
        public void assignResidentToARoom(int residentID)
        {

        }
    }
}