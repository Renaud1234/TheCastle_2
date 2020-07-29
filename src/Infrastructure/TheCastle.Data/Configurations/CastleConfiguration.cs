using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheCastle.Domain.Entities;

namespace TheCastle.Data.Configurations
{
    public class CastleConfiguration : IEntityTypeConfiguration<Castle>
    {
        public void Configure(EntityTypeBuilder<Castle> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.ArmyId)
                .HasColumnName("Army");

            builder.HasOne(c => c.Army)
                .WithMany(a => a.Castles)
                .HasForeignKey(c => c.ArmyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Castles_Armies_Army");
        }
    }
}
