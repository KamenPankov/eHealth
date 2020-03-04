using Data;
using Data.Models;
using Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using SeedDb;
using Services.AddressesService;
using Services.AllergiesServise;
using Services.BloodsService;
using Services.ChronicDiseasesService;
using Services.DoctorsService;
using Services.EmailsService;
using Services.ExaminationsService;
using Services.HospitalizationsService;
using Services.MedicinesService;
using Services.PersonAllergiesService;
using Services.PersonChronicDiseasesService;
using Services.PersonDiseasesInfoService;
using Services.PersonsService;
using Services.PersonVaccinesService;
using Services.PhonesService;
using Services.PrescriptionsService;
using Services.ReferralsService;
using Services.RelativesService;
using Services.ServiceModels;
using Services.TreatmentsService;
using Services.VaccinesService;
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
                IVaccinesService vaccinesService = new VaccinesService(db);
                IAllergiesService allergiesService = new AllergiesService(db);
                IChronicDiseasesService chronicDiseasesService = new ChronicDiseasesService(db);
                IPersonDiseasesService personVaccinesService = new PersonVaccinesService(db, vaccinesService);
                IPersonDiseasesService personAlleriesService = new PersonAllergiesService(db, allergiesService);
                IPersonDiseasesService personChronicDiseasesService = new PersonChronicDiseasesService(db, chronicDiseasesService);
                IMedicinesService medicinesService = new MedicinesService(db);
                IPrescriptionsService prescriptionsService = new PrescriptionsService(db, medicinesService);
                IReferralsService referralsService = new ReferralsService(db);
                ITreatmentsService treatmentsService = new TreatmentsService(db);
                IExaminationsService examinationsService = new ExaminationsService(db);
                IHospitalizationsService hospitalizationsService = new HospitalizationsService(db, examinationsService, treatmentsService);




                #region
                //examinationsService.Add(new ExaminationInputModel()
                //{
                //    Date = "21.09.2019",
                //    Diagnosis = "very sick man",
                //    DoctorId = "bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    PersonId = "9c591451-96e6-4dff-a225-32f092c7b56d",

                //});


                //prescriptionsService.Add("565d1e5a-68df-45ab-8fea-e9d914fc891f");

                //prescriptionsService.AddMedicine("7db87d46-6d71-4355-a482-95e2bf726465",
                //    new MedicineInputModel()
                //    {
                //        Name = "Mesalazin Unipharm",
                //        DaylyDoze = "250mg"
                //    });

                //examinationsService.AddPrescription("565d1e5a-68df-45ab-8fea-e9d914fc891f", "7db87d46-6d71-4355-a482-95e2bf726465");

                //string referralId = referralsService.Add(new ReferralInputModel()
                //                                    {
                //                                        ExaminationId = "565d1e5a-68df-45ab-8fea-e9d914fc891f",
                //                                        Specialty = "Cardiologist"
                //                                    });

                //examinationsService.AddReferral("565d1e5a-68df-45ab-8fea-e9d914fc891f", referralId);

                //hospitalizationsService.AddExamination("22a65132-1949-4e13-bbbc-35201429d0fb", "565d1e5a-68df-45ab-8fea-e9d914fc891f");
                //hospitalizationsService.AddTreatment("22a65132-1949-4e13-bbbc-35201429d0fb", "44f6112f-542a-4eaf-a0b9-5685441f3937");


                //hospitalizationsService.Add(new HospitalizationInputModel()
                //{
                //    EnterDate = "20.08.2019",
                //    DischargeDate = "25.08.2019",
                //    HospitalId = 1,
                //    PersonId = "9c591451-96e6-4dff-a225-32f092c7b56d"
                //});

                //hospitalizationsService.Add(new HospitalizationInputModel()
                //{
                //    EnterDate = "20.09.2019",
                //    HospitalId = 1,
                //    PersonId = "9c591451-96e6-4dff-a225-32f092c7b56d"
                //});


                //treatmentsService.Add(new TreatmentInputModel()
                //{
                //    Description = "knee surgery...",
                //    Date = "21.09.2019",
                //    DoctorId = "bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    HospitalizationId = "22a65132-1949-4e13-bbbc-35201429d0fb"
                //});

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



                //personChronicDiseasesService.AddPersonDiseaseInfo("bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    "9c591451-96e6-4dff-a225-32f092c7b56d", new PersonDiseaseInfoInputModel()
                //    {
                //        Name = "Parkinson disease",
                //        DiagnosedOn = "13.10.1973"
                //    });

                //personChronicDiseasesService.AddPersonDiseaseInfo("bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    "9c591451-96e6-4dff-a225-32f092c7b56d", new PersonDiseaseInfoInputModel()
                //    {
                //        Name = "Parkinson disease new",
                //        DiagnosedOn = "13.10.1973"
                //    });

                //personAlleriesService.AddPersonDiseaseInfo("bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    "9c591451-96e6-4dff-a225-32f092c7b56d", new PersonDiseaseInfoInputModel()
                //    {
                //        Name = "Wheat[26]",
                //        DiagnosedOn = "13.10.1973"
                //    });

                //personAlleriesService.AddPersonDiseaseInfo("bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    "9c591451-96e6-4dff-a225-32f092c7b56d", new PersonDiseaseInfoInputModel()
                //    {
                //        Name = "Wheat[26] (1)",
                //        DiagnosedOn = "13.10.1973"
                //    });

                //personVaccinesService.AddPersonDiseaseInfo("bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    "9c591451-96e6-4dff-a225-32f092c7b56d", new PersonDiseaseInfoInputModel()
                //    {
                //        Name = "Strontium chloride",
                //        DiagnosedOn = "13.10.1973"
                //    });

                //personVaccinesService.AddPersonDiseaseInfo("bedfa8a0-46d7-4369-8f85-fe3b1be57095",
                //    "9c591451-96e6-4dff-a225-32f092c7b56d", new PersonDiseaseInfoInputModel()
                //    {
                //        Name = "Strontium chloride new",
                //        DiagnosedOn = "13.10.1973"
                //    });

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


                #endregion
            }
        }
    }
}
