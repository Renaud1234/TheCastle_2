using TheCastle.Domain.Entities;
using TheCastle.Domain.Interfaces;

namespace TheCastle.Data.Repositories
{
    public class CastleRepository : GenericRepository<Castle>, ICastleRepository
    {
        public CastleRepository(TheCastleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
