using Data;
using Data.Models;
using Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using SeedDb;
using Services.AddressesService;
using Services.BloodsService;
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
                db.Database.Migrate();

                Seed seed = new Seed();

                seed.SeedDataBase(db);

                IBloodsService bloodsService = new BloodsService(db);
                IAddressesService addressesService = new AddressesService(db);
                IPhonesService phonesService = new PhonesService(db);
                IEmailsService emailsService = new EmailsService(db);
                IRelativesService relativesService = new RelativesService(db, addressesService, phonesService, emailsService);
                IPersonsService personsService = new PersonsService(db, addressesService, phonesService, emailsService, relativesService);

                //PersonInputModel personInputModel = new PersonInputModel()
                //{
                //    FirstName = "Kamen",
                //    MiddleName = "Dimitrov",
                //    LastName = "Pankov",
                //    PersonalNumber = 7310136488,
                //    BloodId = bloodsService.GetBloodId(BloodType.A, RhD.Negative),
                //    HasHealthInsurance = true,

                //};

                //personsService.Add(personInputModel);

                Person person = personsService.GetPerson("a1e49c97-3ef5-4e05-b44c-2c8315e96df1");

                personsService.AddAddress("a1e49c97-3ef5-4e05-b44c-2c8315e96df1", new AddressInputModel()
                {
                    Town = "Sofia",
                    Street = "Lerin, 45"
                });
            }
        }
    }
}
