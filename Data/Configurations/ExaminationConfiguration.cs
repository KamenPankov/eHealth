using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class ExaminationConfiguration : IEntityTypeConfiguration<Examination>
    {
        public void Configure(EntityTypeBuilder<Examination> examination)
        {
            examination.HasOne(e => e.Doctor)
                .WithMany(d => d.Examinations)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            examination.HasOne(e => e.Person)
                .WithMany(p => p.Examinations)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            examination.HasOne(e => e.Prescription)
                .WithOne(p => p.Examination)
                .HasForeignKey<Prescription>(e => e.ExaminationId)
                .OnDelete(DeleteBehavior.Restrict);

            examination.HasOne(e => e.Referral)
                .WithOne(r => r.Examination)
                .HasForeignKey<Referral>(e => e.ExaminationId)
                .OnDelete(DeleteBehavior.Restrict);

            examination.HasOne(e => e.Hospitalization)
               .WithMany(h => h.Examinations)
               .HasForeignKey(e => e.HospitalizationId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
