using Data;
using Data.Models;
using Services.ServiceModels;
using System;

namespace Services.TreatmentsService
{
    public class TreatmentsService : ITreatmentsService
    {
        private readonly HealthDbContext db;

        public TreatmentsService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(TreatmentInputModel inputModel)
        {
            Treatment treatment = new Treatment()
            {
                Description = inputModel.Description,
                Date = DateTime.Parse(inputModel.Date),
                DoctorId = inputModel.DoctorId,
                HospitalizationId = inputModel.HospitalizationId
            };

            this.db.Treatments.Add(treatment);
            this.db.SaveChanges();

            return treatment.Id;
        }

        public Treatment GetTreatment(string treatmentId)
        {
           return this.db.Treatments.Find(treatmentId);
        }
    }
}
