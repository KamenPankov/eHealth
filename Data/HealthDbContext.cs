using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data
{
    public class HealthDbContext : DbContext
    {
        public HealthDbContext()
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Relative> Relatives { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<EmailAddress> EmailAddresses { get; set; }

        public DbSet<Blood> Bloods { get; set; }

        public DbSet<Allergy> Allergies { get; set; }

        public DbSet<Vaccine> Vaccines { get; set; }

        public DbSet<ChronicDisease> ChronicDiseases { get; set; }

        public DbSet<Examination> Examinations { get; set; }

        public DbSet<Hospitalization> Hospitalizations { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Referral> Referrals { get; set; }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<PersonAllergy> PersonAllergies { get; set; }

        public DbSet<PersonChronicDisease> PersonChronicDiseases { get; set; }

        public DbSet<PersonVaccine> PersonVaccines { get; set; }

        public DbSet<PersonRelative> PersonRelatives { get; set; }

        public DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Constants.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
