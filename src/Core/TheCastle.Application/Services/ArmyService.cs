using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TheCastle.Application.Interfaces;
using TheCastle.Domain.Entities;
using TheCastle.Domain.Interfaces;

namespace TheCastle.Application.Services
{
    public class ArmyService : GenericService<Army>, IArmyService
    {
        private readonly IArmyRepository _armyRepository;

        public ArmyService(IArmyRepository armyRepo) : base(armyRepo)
        {
            _armyRepository = armyRepo;
        }



        public async Task<Army> GetOneWithDetails(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Id null", nameof(id));
            }

            return await _armyRepository.GetAll()
                .AsNoTracking()
                .Include(x => x.Castles)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
