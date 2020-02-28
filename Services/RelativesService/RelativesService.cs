using Data;
using Data.Models;
using Services.AddressesService;
using Services.EmailsService;
using Services.PhonesService;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.RelativesService
{
    public class RelativesService : IRelativesService
    {
        private readonly HealthDbContext db;

        private readonly IAddressesService addressesService;
        private readonly IPhonesService phonesService;
        private readonly IEmailsService emailsService;

        public RelativesService(HealthDbContext db,
                                IAddressesService addressesService,
                                IPhonesService phonesService,
                                IEmailsService emailsService)
        {
            this.db = db;

            this.addressesService = addressesService;
            this.phonesService = phonesService;
            this.emailsService = emailsService;
        }

        public string Add(RelativeInputModel relativeInputModel)
        {
            Relative relative = new Relative()
            {
                RelativeType = relativeInputModel.RelativeType,
                FirstName = relativeInputModel.FirstName,
                MiddleName = relativeInputModel.MiddleName,
                LastName = relativeInputModel.LastName
            };

            if (relativeInputModel.Address != null)
            {
                string addressId = this.addressesService.Add(relativeInputModel.Address);
                Address address = this.addressesService.GetAddress(addressId);
                relative.Addresses.Add(address);
            }

            if (relativeInputModel.Phone != null)
            {
                string phoneId = this.phonesService.Add(relativeInputModel.Phone);
                Phone phone = this.phonesService.GetPhone(phoneId);
                relative.Phones.Add(phone);
            }

            if (relativeInputModel.Email != null)
            {
                string emailId = this.emailsService.Add(relativeInputModel.Email);
                EmailAddress email = this.emailsService.GetEmail(emailId);
                relative.Emails.Add(email);
            }


            this.db.Relatives.Add(relative);
            this.db.SaveChanges();

            return relative.Id;
        }

        public Relative GetRelative(string id)
        {
            return this.db.Relatives.FirstOrDefault(r => r.Id == id);
        }
    }
}
