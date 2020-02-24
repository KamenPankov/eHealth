using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> treatment)
        {
            treatment.HasOne(t => t.Hospitalization)
                .WithMany(h => h.Treatments)
                .HasForeignKey(t => t.HospitalizationId)
                .OnDelete(DeleteBehavior.Restrict);

            treatment.HasOne(t => t.Doctor)
                .WithMany(d => d.Treatments)
                .HasForeignKey(t => t.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
