using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class HospitalizationConfiguration : IEntityTypeConfiguration<Hospitalization>
    {
        public void Configure(EntityTypeBuilder<Hospitalization> hospitalization)
        {
            hospitalization.HasOne(h => h.Hospital)
                .WithMany(hospital => hospital.Hospitalizations)
                .HasForeignKey(h => h.HospitalId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
