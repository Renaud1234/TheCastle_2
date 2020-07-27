using System.Threading.Tasks;
using TheCastle.Domain.Entities;

namespace TheCastle.Application.Interfaces
{
    public interface IArmyService : IGenericService<Army>
    {
        Task<Army> GetOneWithDetails(int? id);
    }
}
