using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Receptionist : AbstractPrivilegedWorker
    {
        ListRepositry listOfResidents = new ListRepositry();

        public Receptionist(int id, string userName, int age, string email, string phoneNumber, int salary, string jobTitle, string incomeType, string password) :
            base(id, userName, age, email, phoneNumber, salary, jobTitle, incomeType, password) { }
        public override void addUser(AbstractUser newResident)
        {
            listOfResidents.add(newResident);
        }
        public override void deleteUser(AbstractUser curResident)
        {
            listOfResidents.delete(curResident);
        }
        public override void editUser(AbstractUser curResident)
        {
            listOfResidents.delete(curResident);
            listOfResidents.add(curResident);
        }
        public void assignResidentToARoom(int residentID, string roomType)
        {
            // check availiablity of the room , then decrement the number of 
       
        }
    }
}