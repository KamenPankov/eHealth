using Data.Models;
using Services.ServiceModels;
using System;

namespace Services.PersonsService
{
    public interface IPersonsService
    {
        void Add(PersonInputModel personInputModel);

        void AddRelative(string personId, RelativeInputModel relativeInputModel);

        void AddAddress(string personId, AddressInputModel addressInputModel);

        Person GetPerson(string personId);
    }
}
