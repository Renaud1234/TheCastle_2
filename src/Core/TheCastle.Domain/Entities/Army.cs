using System.Collections.Generic;
using TheCastle.Domain.Entities.Base;

namespace TheCastle.Domain.Entities
{
    public class Army : BaseEntity
    {
        // Init Collection
        public Army()
        {
            Castles = new HashSet<Castle>();
        }


        // Entity properties
        public string Name { get; set; }


        // Navigation properties
        public ICollection<Castle> Castles { get; private set; }
    }
}
