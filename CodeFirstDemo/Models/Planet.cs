using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models;

public class Planet
{
    public int PlanetId { get; set; }

    public string Name { get; set; } = "";

    public List<Character>? NativeCharacters { get; set; }
}
