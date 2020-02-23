using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class RelativeConfiguration : IEntityTypeConfiguration<Relative>
    {
        public void Configure(EntityTypeBuilder<Relative> relative)
        {
            relative.HasMany(r => r.Addresses)
                .WithOne(a => a.Relative)
                .HasForeignKey(a => a.RelativeId)
                .OnDelete(DeleteBehavior.Restrict);

            relative.HasMany(r => r.Phones)
                .WithOne(ph => ph.Relative)
                .HasForeignKey(ph => ph.RelativeId)
                .OnDelete(DeleteBehavior.Restrict);

            relative.HasMany(r => r.Emails)
                .WithOne(e => e.Relative)
                .HasForeignKey(e => e.RelativeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
