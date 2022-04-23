using Backend;
using Backend.Models;
using System;


public static class UserAuthenticationServices
{

    public static bool Signin(string Password, string username, bool IsWorker)
    {

        if (IsWorker)
        {
            for (Iterator WorkerIterator = Apphost.ListOfPrivilegedWorkers.GetIterator(); WorkerIterator.hasNext();)
            {
                AbstractPrivilegedWorker Worker = WorkerIterator.getNext() as AbstractPrivilegedWorker;
                if (Worker.userName == username)
                {
                    return (Worker.password == Password); 
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
                    return (Residents.password == Password);
                }
            }
        }
        return false;
    }

}