using Data;
using Data.Models;
using Services.AllergiesServise;
using Services.PersonDiseasesInfoService;
using Services.ServiceModels;
using System;

namespace Services.PersonAllergiesService
{
    public class PersonAllergiesService : IPersonDiseasesService
    {
        private readonly HealthDbContext db;
        private readonly IAllergiesService allergiesService;

        public PersonAllergiesService(HealthDbContext db, IAllergiesService allergiesService)
        {
            this.db = db;
            this.allergiesService = allergiesService;
        }

        public HealthDbContext Db { get; }

        public void AddPersonDiseaseInfo(string doctorId, string personId, PersonDiseaseInfoInputModel diseaseInputModel)
        {
            Allergy allergy = null;
            int allergyId = this.allergiesService.GetAllergyId(diseaseInputModel.Name);

            if (allergyId == 0)
            {
                allergyId = allergiesService.Add(diseaseInputModel.Name);
                allergy = this.allergiesService.GetAllergy(allergyId);
            }
            else
            {
                allergy = this.allergiesService.GetAllergy(allergyId);
            }

            PersonAllergy personAllergy = new PersonAllergy()
            {
                DoctorId = doctorId,
                PersonId = personId,
                Allergy = allergy,
                DiagnosedOn = DateTime.Parse(diseaseInputModel.DiagnosedOn)
            };

            this.db.PersonAllergies.Add(personAllergy);
            this.db.SaveChanges();
        }
    }
}
