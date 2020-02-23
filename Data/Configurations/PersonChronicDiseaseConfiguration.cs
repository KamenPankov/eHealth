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
            personChronicDisease.HasKey(pchd => new { pchd.PersonId, pchd.ChronicDiseaseId });

            personChronicDisease.HasOne(pchd => pchd.Doctor)
                .WithMany(d => d.PersonChronicDiseases)
                .HasForeignKey(pchd => pchd.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
