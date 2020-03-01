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
            

            personAllergy.HasOne(pa => pa.Doctor)
                .WithMany(d => d.PersonAllergies)
                .HasForeignKey(pa => pa.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            personAllergy.HasOne(pa => pa.Person)
                .WithMany(p => p.Allergies)
                .HasForeignKey(pa => pa.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            personAllergy.HasOne(pa => pa.Allergy)
                .WithMany(a => a.Persons)
                .HasForeignKey(pa => pa.AllergyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
