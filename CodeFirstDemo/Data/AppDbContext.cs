using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Data;

public class AppDbContext : DbContext
{
	public AppDbContext()
	{

	}

	public AppDbContext(DbContextOptions options) : base(options)
	{

	}

	public virtual DbSet<Character> Characters { get; set; } // Detta äre n tabell av characters som består av characters.
	public virtual DbSet<Planet> Planets { get; set; } // Detta är en tabell av planets som består av planets.
	public virtual DbSet<Spaceship> Spaceships { get; set; } // Tredje tabellen i databasen.

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// Här beskriver vi anslutningen till servern/databasen, kan stå vad som helt efter Database= då detta är codefirst approach.

		optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StarWarsDb;Trusted_Connection=True;"); 

	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Planet>().HasData(new Planet()
		{
			PlanetId = 1,
			Name = "Tatooine"
		}, new Planet()
		{
            PlanetId = 2,
            Name = "Dagobah"
        }, new Planet()
		{
			PlanetId = 3,
			Name = "Stewjon"
        });

		modelBuilder.Entity<Character>().HasData(new Character()
		{
			CharacterId = 1,
			FirstName = "Luke",
			LastName = "Skywalker",
			Species = "Human",
			IsDarkSide = false,
			HasTheForce = true,
			HomePlanetId = 1
		}, new Character()
		{
            CharacterId = 2,
            FirstName = "Obi-Wan",
            LastName = "Kenobi",
            Species = "Human",
            IsDarkSide = false,
            HasTheForce = true,
            HomePlanetId = 3
        });
	}
}
