using Data;
using Data.Models;
using Services.AddressesService;
using Services.EmailsService;
using Services.PhonesService;
using Services.RelativesService;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PersonsService
{
    public class PersonsService : IPersonsService
    {
        private readonly HealthDbContext db;

        private readonly IAddressesService addressesService;
        private readonly IPhonesService phonesService;
        private readonly IEmailsService emailsService;
        private readonly IRelativesService relativesService;
        
        public PersonsService(HealthDbContext db,
                              IAddressesService addressesService,
                              IPhonesService phonesService,
                              IEmailsService emailsService,
                              IRelativesService relativesService)
        {
            this.db = db;

            this.addressesService = addressesService;
            this.phonesService = phonesService;
            this.emailsService = emailsService;
            this.relativesService = relativesService;
        }

        public Person GetPerson(string personId)
        {
            return this.db.Persons.Find(personId);
        }

        public void Add(PersonInputModel personInputModel)
        {
            Person person = new Person()
            {
                FirstName = personInputModel.FirstName,
                MiddleName = personInputModel.MiddleName,
                LastName = personInputModel.LastName,
                PersonalNumber = personInputModel.PersonalNumber,
                HasHealthInsurance = personInputModel.HasHealthInsurance,
                BloodId = personInputModel.BloodId,
                DoctorId = personInputModel.DoctorId
            };

            if (personInputModel.Address != null)
            {
                string addressId = this.addressesService.Add(personInputModel.Address);
                Address address = this.addressesService.GetAddress(addressId);
                person.Addresses.Add(address);
            }

            if (personInputModel.Phone != null)
            {
                string phoneId = this.phonesService.Add(personInputModel.Phone);
                Phone phone = this.phonesService.GetPhone(phoneId);
                person.Phones.Add(phone);
            }

            if (personInputModel.Email != null)
            {
                string emailId = this.emailsService.Add(personInputModel.Email);
                EmailAddress emailAddress = this.emailsService.GetEmail(emailId);
                person.Emails.Add(emailAddress);
            }            

            this.db.Persons.Add(person);
            this.db.SaveChanges();

        }

        public void AddAddress(string personId, AddressInputModel addressInputModel)
        {
            Person person = this.GetPerson(personId);

            string addressId = this.addressesService.Add(addressInputModel);

            person.Addresses.Add(this.addressesService.GetAddress(addressId));

            this.db.SaveChanges();
        }

        public void AddRelative(string personId, RelativeInputModel relativeInputModel)
        {
            Person person = this.GetPerson(personId);

            string relativeId = this.relativesService.Add(relativeInputModel);

            PersonRelative personRelative = new PersonRelative()
            {
                PersonId = person.Id,
                RelativeId = relativeId
            };

            this.db.PersonRelatives.Add(personRelative);
            this.db.SaveChanges();
        }       

        
    }
}
