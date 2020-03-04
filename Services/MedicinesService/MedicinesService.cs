using Data;
using Data.Models;
using Services.ServiceModels;
using System.Linq;

namespace Services.MedicinesService
{
    public class MedicinesService : IMedicinesService
    {
        private readonly HealthDbContext db;

        public MedicinesService(HealthDbContext db)
        {
            this.db = db;
        }

        public string Add(MedicineInputModel inputModel)
        {
            Medicine medicine = new Medicine()
            {
                Name = inputModel.Name,
                DaylyDoze = inputModel.DaylyDoze
            };

            this.db.Medicines.Add(medicine);
            this.db.SaveChanges();

            return medicine.Id;
        }

        public string GetMedicineId(string name)
        {
            return this.db.Medicines
                .Where(m => m.Name == name)
                .Select(m => m.Id)
                .FirstOrDefault();
        }
    }
}
