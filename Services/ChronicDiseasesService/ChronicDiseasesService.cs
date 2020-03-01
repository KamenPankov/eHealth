using Data;
using Data.Models;
using System;
using System.Linq;

namespace Services.ChronicDiseasesService
{   
    public class ChronicDiseasesService : IChronicDiseasesService
    {
        private readonly HealthDbContext db;

        public ChronicDiseasesService(HealthDbContext db)
        {
            this.db = db;
        }

        public int Add(string name)
        {
            ChronicDisease chronicDisease = new ChronicDisease()
            {
                Name = name
            };

            this.db.ChronicDiseases.Add(chronicDisease);
            this.db.SaveChanges();

            return (int)this.GetDiseaseId(chronicDisease.Name);
        }

        public int GetDiseaseId(string name)
        {
            return  (int)this.db.ChronicDiseases
                .Where(d => d.Name == name)
                .Select(d => d.Id)
                .FirstOrDefault();
        }

        public ChronicDisease GetDisease(int diseaseId)
        {
            return this.db.ChronicDiseases.Find(diseaseId);
        }
    }
}
