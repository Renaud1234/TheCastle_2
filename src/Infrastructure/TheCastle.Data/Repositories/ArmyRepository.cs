using TheCastle.Domain.Entities;
using TheCastle.Domain.Interfaces;

namespace TheCastle.Data.Repositories
{
    public class ArmyRepository : GenericRepository<Army>, IArmyRepository
    {
        public ArmyRepository(TheCastleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
