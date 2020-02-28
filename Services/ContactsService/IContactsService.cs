using Data;
using Data.Models;
using Services.AddressesService;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ContactsService
{
    public interface IContactsService
    {
        void AddAddress(string id, AddressInputModel addressInputModel);

        void AddPhone(string id, PhoneInputModel phoneInputModel);

        void AddEmail(string id, EmailAddressInputModel emailAddressInputModel);
    }

    
}
