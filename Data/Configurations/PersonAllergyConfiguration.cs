using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class PersonAllergyConfiguration : IEntityTypeConfiguration<PersonAllergy>
    {
        public void Configure(EntityTypeBuilder<PersonAllergy> personAllergy)
        {
            personAllergy.HasKey(pa => new { pa.PersonId, pa.AllergyId });

            personAllergy.HasOne(pa => pa.Doctor)
                .WithMany(d => d.PersonAllergies)
                .HasForeignKey(pa => pa.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
