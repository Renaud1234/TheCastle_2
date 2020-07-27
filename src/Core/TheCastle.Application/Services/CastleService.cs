using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TheCastle.Application.Interfaces;
using TheCastle.Domain.Entities;
using TheCastle.Domain.Interfaces;

namespace TheCastle.Application.Services
{
    public class CastleService : GenericService<Castle>, ICastleService
    {
        private readonly ICastleRepository _castleRepository;

        public CastleService(ICastleRepository castleRepo) : base(castleRepo)
        {
            _castleRepository = castleRepo;
        }



        public async Task<Castle> GetOneWithDetails(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Id null", nameof(id));
            }

            return await _castleRepository.GetAll()
                .AsNoTracking()
                .Include(x => x.Army)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
