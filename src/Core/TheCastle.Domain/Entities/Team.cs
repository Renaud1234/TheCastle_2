using System;
using System.Collections.Generic;
using System.Text;
using TheCastle.Domain.Entities.Base;

namespace TheCastle.Domain.Entities
{
    public class Team
    {
        // Init Collections
        public Team()
        {
            Players = new HashSet<Player>();
        }

        // Entity properties
        public int Id { get; set; }

        public string Name { get; set; }


        // Navigation properties
        public ICollection<Player> Players { get; private set; }
    }
}
