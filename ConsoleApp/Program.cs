using Data;
using Data.Models;
using Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using SeedDb;
using Services.AddressesService;
using Services.BloodsService;
using Services.DoctorsService;
using Services.EmailsService;
using Services.PersonsService;
using Services.PhonesService;
using Services.RelativesService;
using Services.ServiceModels;
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            using (HealthDbContext db = new HealthDbContext())
            {
                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();

                db.Database.Migrate();

                //Seed seed = new Seed();
                //seed.SeedDataBase(db);

                IBloodsService bloodsService = new BloodsService(db);
                IAddressesService addressesService = new AddressesService(db);
                IPhonesService phonesService = new PhonesService(db);
                IEmailsService emailsService = new EmailsService(db);
                IRelativesService relativesService = new RelativesService(db, addressesService, phonesService, emailsService);
                IDoctorsService doctorsService = new DoctorsService(db, addressesService, phonesService, emailsService);
                IPersonsService personsService = new PersonsService(db, addressesService, phonesService, emailsService, relativesService);

                //PersonInputModel personInputModel = new PersonInputModel()
                //{
                //    FirstName = "Kamen",
                //    MiddleName = "Dimitrov",
                //    LastName = "Pankov",
                //    PersonalNumber = "7310136488",
                //    BloodId = bloodsService.GetBloodId(BloodType.A, RhD.Negative),
                //    HasHealthInsurance = true,
                //    Address = new AddressInputModel()
                //    {
                //        Town = "Sofia",
                //        Street = "Lerin 45"
                //    }
                //};

                //personsService.Add(personInputModel);

                //Person person = personsService.GetPerson("9c591451-96e6-4dff-a225-32f092c7b56d");

                //personsService.AddPhone("9c591451-96e6-4dff-a225-32f092c7b56d", new PhoneInputModel()
                //{
                //    PhoneNumber = "0888086820"
                //});

                //personsService.AddEmail("9c591451-96e6-4dff-a225-32f092c7b56d", new EmailAddressInputModel()
                //{
                //    Email = "kamen.pankov@gmail.com"
                //});

                //personsService.AddRelative("9c591451-96e6-4dff-a225-32f092c7b56d",
                //    new RelativeInputModel()
                //    {
                //        FirstName = "Desi",
                //        MiddleName = "Svetlozarova",
                //        LastName = "Velkovska",
                //        Address = new AddressInputModel()
                //        {
                //            Town = "Sofia",
                //            Street = "ul. Dobrudjanski krai 1"
                //        },
                //        Phone = new PhoneInputModel()
                //        {
                //            PhoneNumber = "0888127876"
                //        },
                //        Email = new EmailAddressInputModel()
                //        {
                //            Email = "desi.velkovska@gmail.com"
                //        },
                //        RelativeType = "spouse"
                //    });

                //doctorsService.Add(new DoctorInputModel()
                //{
                //    FirstName = "Boiko",
                //    LastName = "Penkov",
                //    HospitalId = 1,
                //    Specialty = "Cardiologist",
                //    Address = new AddressInputModel()
                //    {
                //        Town = "Sofia",
                //        Street = "ul. Alen Mak 1"
                //    },
                //    Phone = new PhoneInputModel()
                //    {
                //        PhoneNumber = "0888989898"
                //    },
                //    Email = new EmailAddressInputModel()
                //    {
                //        Email = "boiko.penkov@gmail.com"
                //    },
                //});
            }
        }
    }
}
