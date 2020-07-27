using System.Threading.Tasks;
using TheCastle.Domain.Entities;

namespace TheCastle.Application.Interfaces
{
    public interface ICastleService : IGenericService<Castle>
    {
        Task<Castle> GetOneWithDetails(int? id);
    }
}
