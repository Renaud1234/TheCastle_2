using Microsoft.EntityFrameworkCore;
using TheCastle.Domain.Entities;

namespace TheCastle.Data
{
    public class TheCastleDbContext : DbContext
    {
        public TheCastleDbContext(DbContextOptions<TheCastleDbContext> options)
            : base(options)
        {
        }

        public DbSet<Castle> Castles { get; set; }
        public DbSet<Army> Armies { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<DataLog> DataLogs { get; set; }


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
