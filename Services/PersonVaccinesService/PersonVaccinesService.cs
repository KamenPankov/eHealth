using Data;
using Data.Models;
using Services.PersonDiseasesInfoService;
using Services.ServiceModels;
using Services.VaccinesService;
using System;

namespace Services.PersonVaccinesService
{
    public class PersonVaccinesService : IPersonDiseasesService
    {
        private readonly HealthDbContext db;
        private readonly IVaccinesService vaccinesService;

        public PersonVaccinesService(HealthDbContext db, IVaccinesService vaccinesService)
        {
            this.db = db;
            this.vaccinesService = vaccinesService;
        }

        public void AddPersonDiseaseInfo(string doctorId, string personId, PersonDiseaseInfoInputModel diseaseInputModel)
        {
            Vaccine vaccine = null;
            int vaccineId = this.vaccinesService.GetVaccineId(diseaseInputModel.Name);

            if (vaccineId == 0)
            {
                vaccineId = this.vaccinesService.Add(diseaseInputModel.Name);
                vaccine = vaccinesService.GetVaccine(vaccineId);
            }
            else
            {
                vaccine = vaccinesService.GetVaccine(vaccineId);
            }

            PersonVaccine personVaccine = new PersonVaccine()
            {
                DoctorId = doctorId,
                PersonId = personId,
                Vaccine = vaccine,
                DiagnosedOn = DateTime.Parse(diseaseInputModel.DiagnosedOn)
            };

            this.db.PersonVaccines.Add(personVaccine);
            this.db.SaveChanges();
        }
    }
}
