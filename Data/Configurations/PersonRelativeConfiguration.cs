using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class PersonRelativeConfiguration : IEntityTypeConfiguration<PersonRelative>
    {
        public void Configure(EntityTypeBuilder<PersonRelative> personRelative)
        {
            personRelative.HasKey(pr => new { pr.PersonId, pr.RelativeId });
        }
    }
}
