using Backend;
using Backend.Models;
using System;


public static class UserAuthenticationServices
{

    public static string Signin(string Password, string username, bool IsWorker)
    {

        if (IsWorker)
        {
            for (Iterator WorkerIterator = Apphost.ListOfPrivilegedWorkers.GetIterator(); WorkerIterator.hasNext();)
            {
                AbstractPrivilegedWorker Worker = WorkerIterator.getNext() as AbstractPrivilegedWorker;
                if (Worker.userName == username)
                {
                    return (Worker.password == Password) ? ( (Worker.jobTitle == JobTitle.Manager) ? "Manager" : "Receptionist") : "Failed"; 
                }
            }
        }
        else
        {
            for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
            {
                Resident Residents = ResidentsIterator.getNext() as Resident;
                if (Residents.userName == username)
                {
                    return (Residents.password == Password) ? "Resident" : "Failed";
                }
            }
        }
        return "Failed";
    }

}