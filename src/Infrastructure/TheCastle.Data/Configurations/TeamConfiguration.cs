using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheCastle.Domain.Entities;

namespace TheCastle.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(e => e.Id)
                .IsRequired()
                .HasColumnName("Team");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
