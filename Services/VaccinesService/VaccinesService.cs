using Data;
using Data.Models;
using System;
using System.Linq;

namespace Services.VaccinesService
{
    public class VaccinesService : IVaccinesService
    {
        private readonly HealthDbContext db;

        public VaccinesService(HealthDbContext db)
        {
            this.db = db;
        }

        public int Add(string name)
        {
            Vaccine vaccine = new Vaccine()
            {
                Name = name
            };

            this.db.Vaccines.Add(vaccine);
            this.db.SaveChanges();

            return (int)this.GetVaccineId(vaccine.Name);
        }

        public Vaccine GetVaccine(int vaccineId)
        {
            return this.db.Vaccines.Find(vaccineId);
        }

        public int GetVaccineId(string name)
        {
            return this.db.Vaccines
                .Where(v => v.Name == name)
                .Select(v => v.Id)
                .FirstOrDefault();
        }
    }
}
