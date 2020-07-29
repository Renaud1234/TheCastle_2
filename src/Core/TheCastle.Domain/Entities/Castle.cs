using TheCastle.Domain.Entities.Base;

namespace TheCastle.Domain.Entities
{
    public class Castle : BaseEntity
    {
        // Entity properties
        public string Name { get; set; }
        public int? ArmyId { get; set; }


        // Navigation properties
        public Army Army { get; set; }
    }
}
