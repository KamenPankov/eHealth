using Data.Models;
using Services.ServiceModels;
using System;

namespace Services.PersonsService
{
    public interface IPersonsService
    {
        void Add(PersonInputModel personInputModel);

        void AddAddress(string personId, AddressInputModel addressInputModel);

        void AddPhone(string personId, PhoneInputModel phoneInputModel);

        void AddEmail(string personId, EmailAddressInputModel emailAddressInputModel);

        void AddRelative(string personId, RelativeInputModel relativeInputModel);

        Person GetPerson(string personId);
    }
}
