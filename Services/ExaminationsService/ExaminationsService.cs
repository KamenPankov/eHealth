using Data;
using Data.Models;
using Services.ServiceModels;
using System;

namespace Services.ExaminationsService
{
    public class ExaminationsService : IExaminationsService
    {
        private readonly HealthDbContext db;

        public ExaminationsService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(ExaminationInputModel inputModel)
        {
            Examination examination = new Examination()
            {
                Date = DateTime.Parse(inputModel.Date),
                Diagnosis = inputModel.Diagnosis,
                PersonId = inputModel.PersonId,
                DoctorId = inputModel.DoctorId,
                PrescriptionId = inputModel.PrescriptionId,
                ReferralId = inputModel.ReferralId,

            };

            this.db.Examinations.Add(examination);
            this.db.SaveChanges();

            return examination.Id;
        }

        public void AddPrescription(string examinationId, string prescriptionId)
        {
            Examination examination = this.GetExamination(examinationId);
            examination.PrescriptionId = prescriptionId;

            this.db.SaveChanges();
        }

        public void AddReferral(string examinationId, string referralId)
        {
            Examination examination = this.GetExamination(examinationId);
            examination.ReferralId = referralId;

            this.db.SaveChanges();
        }

        public Examination GetExamination(string examinationId)
        {
            return this.db.Examinations.Find(examinationId);
        }
    }
}
