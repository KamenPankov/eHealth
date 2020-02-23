using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class PersonVaccineConfiguration : IEntityTypeConfiguration<PersonVaccine>
    {
        public void Configure(EntityTypeBuilder<PersonVaccine> personVaccine)
        {
            personVaccine.HasKey(pv => new { pv.PersonId, pv.VaccineId });

            personVaccine.HasOne(pv => pv.Doctor)
                .WithMany(d => d.PersonVaccines)
                .HasForeignKey(pv => pv.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
