using Data;
using Data.Models;
using Services.ChronicDiseasesService;
using Services.PersonDiseasesInfoService;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PersonChronicDiseasesService
{
    public class PersonChronicDiseasesService : IPersonDiseasesService
    {
        private readonly HealthDbContext db;
        private readonly IChronicDiseasesService diseasesService;

        public PersonChronicDiseasesService(HealthDbContext db, IChronicDiseasesService diseasesService)
        {
            this.db = db;
            this.diseasesService = diseasesService;
        }

        public void AddPersonDiseaseInfo(string doctorId, string personId, PersonDiseaseInfoInputModel personDiseaseInfoInputModel)
        {
            int diseaseId = this.diseasesService.GetDiseaseId(personDiseaseInfoInputModel.Name);
            ChronicDisease chronicDisease = null;

            if (diseaseId == 0)
            {
                diseaseId = this.diseasesService.Add(personDiseaseInfoInputModel.Name);
                chronicDisease = this.diseasesService.GetDisease(diseaseId);
            }
            else
            {
                chronicDisease = this.diseasesService.GetDisease(diseaseId);
            }

            PersonChronicDisease personChronicDisease = new PersonChronicDisease()
            {
                DoctorId = doctorId,
                PersonId = personId,
                DiagnosedOn = DateTime.Parse(personDiseaseInfoInputModel.DiagnosedOn),
                ChronicDisease = chronicDisease
            };

            this.db.PersonChronicDiseases.Add(personChronicDisease);
            this.db.SaveChanges();
        }
    }
}
