using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Configurations
{
    public class PersonChronicDiseaseConfiguration : IEntityTypeConfiguration<PersonChronicDisease>
    {
        public void Configure(EntityTypeBuilder<PersonChronicDisease> personChronicDisease)
        {
           

            personChronicDisease.HasOne(pchd => pchd.Doctor)
                .WithMany(d => d.PersonChronicDiseases)
                .HasForeignKey(pchd => pchd.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            personChronicDisease.HasOne(pchd => pchd.Person)
               .WithMany(p => p.ChronicDiseases)
               .HasForeignKey(pchd => pchd.PersonId)
               .OnDelete(DeleteBehavior.Restrict);

            personChronicDisease.HasOne(pchd => pchd.ChronicDisease)
               .WithMany(chd => chd.Persons)
               .HasForeignKey(pchd => pchd.ChronicDiseaseId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
