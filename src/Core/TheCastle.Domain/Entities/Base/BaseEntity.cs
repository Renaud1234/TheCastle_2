namespace TheCastle.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public int TeamId { get; set; }


        // Navigation properties
        public Team Team { get; set; }
    }
}
