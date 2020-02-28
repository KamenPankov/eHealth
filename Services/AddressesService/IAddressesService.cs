using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.AddressesService
{
    public interface IAddressesService
    {
        string Add(AddressInputModel inputModel);

        Address GetAddress(string id);
    }
}
