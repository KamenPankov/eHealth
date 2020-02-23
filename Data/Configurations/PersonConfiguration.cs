using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> person)
        {
            person.HasIndex(p => p.PersonalNumber);

            person.HasMany(p => p.Addresses)
                .WithOne(a => a.Person)
                .HasForeignKey(a => a.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            person.HasMany(p => p.Phones)
                .WithOne(ph => ph.Person)
                .HasForeignKey(ph => ph.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            person.HasMany(p => p.Emails)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            person.HasOne(p => p.DoctorGP)
                .WithMany(d => d.Persons)
                .HasForeignKey(p => p.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            person.HasOne(p => p.Blood)
                .WithMany(b => b.Persons)
                .HasForeignKey(p => p.BloodId)
                .OnDelete(DeleteBehavior.Restrict);

            person.HasMany(p => p.Examinations)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            person.HasMany(p => p.Hospitalizations)
                .WithOne(h => h.Person)
                .HasForeignKey(e => e.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
