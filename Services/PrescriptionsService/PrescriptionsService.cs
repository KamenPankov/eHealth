using Data;
using Data.Models;
using Services.MedicinesService;
using Services.ServiceModels;

namespace Services.PrescriptionsService
{
    public class PrescriptionsService : IPrescriptionsService
    {
        private readonly HealthDbContext db;
        private readonly IMedicinesService medicinesService;

        public PrescriptionsService(HealthDbContext db, IMedicinesService medicinesService)
        {
            this.db = db;
            this.medicinesService = medicinesService;
        }

        public string Add(string examinationId)
        {
            Prescription prescription = new Prescription()
            {
                ExaminationId = examinationId
            };

            this.db.Prescriptions.Add(prescription);
            this.db.SaveChanges();

            return prescription.Id;
        }

        public void AddMedicine(string prescriptionId, MedicineInputModel inputModel)
        {         
            string medicineId = this.medicinesService.GetMedicineId(inputModel.Name);

            if (string.IsNullOrEmpty(medicineId))
            {
                medicineId = this.medicinesService.Add(inputModel);
            }

            PrescriptionMedicine prescriptionMedicine = new PrescriptionMedicine()
            {
                PrescriptionId = prescriptionId,
                MedicineId = medicineId
            };

            this.db.PrescriptionMedicines.Add(prescriptionMedicine);
            this.db.SaveChanges();
        }
    }
}
