using Data;
using Data.Models;
using System.Linq;

namespace Services.AllergiesServise
{
    public class AllergiesService : IAllergiesService
    {
        private readonly HealthDbContext db;

        public AllergiesService(HealthDbContext db)
        {
            this.db = db;
        }

        public int Add(string name)
        {
            Allergy allergy = new Allergy()
            {
                Name = name
            };

            this.db.Allergies.Add(allergy);
            this.db.SaveChanges();

            return (int)this.GetAllergyId(allergy.Name);
        }

        public Allergy GetAllergy(int allergyId)
        {
            return this.db.Allergies.Find(allergyId);
        }

        public int GetAllergyId(string name)
        {
            return this.db.Allergies
                .Where(a => a.Name == name)
                .Select(a => a.Id)
                .FirstOrDefault();
        }
    }
}
