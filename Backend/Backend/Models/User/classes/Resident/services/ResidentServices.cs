using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend.Models;
namespace Backend.Models.User.classes
{

    public class ResidentServices
    {
        public void EditResident(Resident editedResident)
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident resident = ResidentsIterator.getNext() as Resident;
                if (editedResident.id == resident.id)
                {  
                    resident = editedResident;  //change the pointer
                    break;
                }
            }
        }
        public void AddResident(Resident resident)
        {
            Apphost.ListOfResidents.list.Add(resident);
        }
    }
}