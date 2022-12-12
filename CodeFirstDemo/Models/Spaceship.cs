using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
    public class Spaceship
    {
        public int SpaceshipId { get; set; }

        public string Name { get; set; } = "";

        public bool? HasHyperDrive { get; set; }

        public int OwnerId { get; set; } // FK från Character

        public Character Owner { get; set; } = new();

    }
}
