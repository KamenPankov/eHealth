using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> hospital)
        {
            hospital.HasOne(h => h.Address)
                .WithOne(a => a.Hospital)
                .HasForeignKey<Hospital>(h => h.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
