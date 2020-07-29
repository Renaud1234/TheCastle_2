using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheCastle.Domain.Entities;

namespace TheCastle.Data.Configurations
{
    public class ArmyConfiguration : IEntityTypeConfiguration<Army>
    {
        public void Configure(EntityTypeBuilder<Army> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasMany(a => a.Castles)
                .WithOne(c => c.Army);
        }
    }
}
