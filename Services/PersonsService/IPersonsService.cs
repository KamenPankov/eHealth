using Data.Models;
using Services.ContactsService;
using Services.ServiceModels;
using System;

namespace Services.PersonsService
{
    public interface IPersonsService : IContactsService
    {
        void Add(PersonInputModel personInputModel);        

        void AddRelative(string personId, RelativeInputModel relativeInputModel);
        

        Person GetPerson(string personId);
    }
}
