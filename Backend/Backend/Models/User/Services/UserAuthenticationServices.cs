using Backend;
using Backend.Models;
using System;


public static class UserAuthenticationServices
{

    public static string Signin(string username, string Password,  bool IsWorker)
    {

        if (IsWorker)
        {
            for (Iterator WorkerIterator = Apphost.ListOfPrivilegedWorkers.GetIterator(); WorkerIterator.hasNext();)
            {
                PrivilegedWorker Worker = WorkerIterator.getNext() as PrivilegedWorker;
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

    public static bool isUserNameFound(string userName)
    {
        for (Iterator ResidentsIterator = Apphost.ListOfResidents.GetIterator(); ResidentsIterator.hasNext();)
        {
            Resident resident = ResidentsIterator.getNext() as Resident;
            if (resident.userName == userName) return true;
        }
        for (Iterator workerIterator = Apphost.ListOfRoomServices.GetIterator(); workerIterator.hasNext();)
        {
            Worker roomWorker = workerIterator.getNext() as Worker;
            if (roomWorker.userName == userName) return true;
        }
        for (Iterator workerIterator = Apphost.ListOfPrivilegedWorkers.GetIterator(); workerIterator.hasNext();)
        {
            PrivilegedWorker worker = workerIterator.getNext() as PrivilegedWorker;
            if (worker.userName == userName) return true;
        }
        return false;
    }

}