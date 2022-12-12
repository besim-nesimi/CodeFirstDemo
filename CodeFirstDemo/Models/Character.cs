using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models;

public class Character
{
    public int CharacterId { get; set; }

    public string FirstName { get; set; } = "";

    public string? LastName { get; set; }

    public string? Species { get; set; } 

    public bool? IsDarkSide { get; set; } // Frågetecken efter ? innebär att ngt kan vara nullable.

    public bool HasTheForce { get; set; }

    public int HomePlanetId { get; set; } // FK från Planet

    public Planet? HomePlanet { get; set; } // Nullable

    public List<Spaceship>? Spaceships { get; set; } 
}
