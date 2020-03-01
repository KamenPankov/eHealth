using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class PersonVaccineConfiguration : IEntityTypeConfiguration<PersonVaccine>
    {
        public void Configure(EntityTypeBuilder<PersonVaccine> personVaccine)
        {
            

            personVaccine.HasOne(pv => pv.Doctor)
                .WithMany(d => d.PersonVaccines)
                .HasForeignKey(pv => pv.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            personVaccine.HasOne(pv => pv.Person)
                .WithMany(p => p.Vaccines)
                .HasForeignKey(pv => pv.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            personVaccine.HasOne(pv => pv.Vaccine)
                .WithMany(p => p.Persons)
                .HasForeignKey(pv => pv.VaccineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
