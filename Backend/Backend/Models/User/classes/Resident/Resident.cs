using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Resident : AbstractUser
    {
        public string password;

        public Resident(string userName, int age, string email, string phoneNumber, string password) :
            base(userName, age, email, phoneNumber) 
        {
            this.password = password;
        }

        public void EditResident(Resident editedResident)
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident resident = ResidentsIterator.getNext() as Resident;
                if (editedResident.id == resident.id)
                {
                    resident = editedResident;
                    break;
                }
            }
        }
        public void AddResident(Resident resident)
        {
            Apphost.ListOfResidents.list.Add(resident);
        }

        //get all reservations --
        //make reservation --
        //edit reservation --
        //cancel reservation --



    }
}