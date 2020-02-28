using Data;
using Data.Models;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.AddressesService
{
    public class AddressesService : IAddressesService
    {
        private HealthDbContext db;

        public AddressesService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(AddressInputModel addressIinputModel)
        {
            Address address = new Address()
            {
                Town = addressIinputModel.Town,
                Street = addressIinputModel.Street,
                AdditionalDescription = addressIinputModel.AdditionalDescription
            };

            this.db.Addresses.Add(address);
            this.db.SaveChanges();

            return address.Id;
        }

        public Address GetAddress(string id)
        {
            return this.db.Addresses.FirstOrDefault(a => a.Id == id);
        }
    }
}
