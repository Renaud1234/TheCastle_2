using System;
using System.Collections.Generic;
using System.Text;
using TheCastle.Domain.Entities.Base;

namespace TheCastle.Domain.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TeamId { get; set; }


        // Navigation properties
        public Team Team { get; set; }
    }
}
