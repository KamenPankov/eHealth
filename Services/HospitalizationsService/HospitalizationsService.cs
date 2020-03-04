using Data;
using Data.Models;
using Services.ExaminationsService;
using Services.ServiceModels;
using Services.TreatmentsService;
using System;

namespace Services.HospitalizationsService
{
    public class HospitalizationsService : IHospitalizationsService
    {
        private readonly HealthDbContext db;
        private readonly IExaminationsService examinationsService;
        private readonly ITreatmentsService treatmentsService;

        public HospitalizationsService(HealthDbContext db,
                                       IExaminationsService examinationsService,
                                       ITreatmentsService treatmentsService)
        {
            this.db = db;
            this.examinationsService = examinationsService;
            this.treatmentsService = treatmentsService;
        }

        public void Add(HospitalizationInputModel inputModel)
        {
            Hospitalization hospitalization = new Hospitalization()
            {
                EnterDate = DateTime.Parse(inputModel.EnterDate),
                DischargeDate = string.IsNullOrEmpty(inputModel.DischargeDate) ? 
                                    (DateTime?)null :
                                    DateTime.Parse(inputModel.DischargeDate),
                HospitalId = inputModel.HospitalId,
                PersonId = inputModel.PersonId
            };

            this.db.Hospitalizations.Add(hospitalization);
            this.db.SaveChanges();
        }

        public Hospitalization GetHospitalization(string hospitalizationId)
        {
            return this.db.Hospitalizations.Find(hospitalizationId);
        }

        public void AddExamination(string hospitalizationId, string examinationId)
        {
            Hospitalization hospitalization = this.GetHospitalization(hospitalizationId);
            hospitalization.Examinations.Add(this.examinationsService.GetExamination((examinationId)));

            this.db.SaveChanges();
        }

        public void AddTreatment(string hospitalizationId, string treatmentId)
        {
            Hospitalization hospitalization = this.GetHospitalization(hospitalizationId);
            hospitalization.Treatments.Add(this.treatmentsService.GetTreatment((treatmentId)));

            this.db.SaveChanges();
        }
    }
}
