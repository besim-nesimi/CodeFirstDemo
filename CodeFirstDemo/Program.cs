
using CodeFirstDemo.Data;
using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Welcome to the SW DB app");

//Adding the planet Tatooine to the DB list.
//using (AppDbContext context = new())
//{
//    // Minst kod
//    context.Planets.Add(new Planet()
//    {
//        Name = "Dagobah"
//    });

//    // Skrivs oavsett
//    context.SaveChanges();
//}

//// Add character to the DB

//using (AppDbContext context = new())
//{
//    context.Characters.Add(new Character()
//    {
//        FirstName = "Luke",
//        LastName = "Skywalker",
//        Species = "Human",
//        IsDarkSide = false,
//        HasTheForce = true,
//        HomePlanet = context.Planets.Where(p => p.Name == "Tatooine").FirstOrDefault()
//    });

//    context.SaveChanges();
//}

// Get character data from DB without lazy loading

//using (AppDbContext context = new())
//{
//    var character = context.Characters.
//        Where(c => c.FirstName == "Luke" && c.LastName == "Skywalker").
//        Include(c => c.HomePlanet).
//        ThenInclude(h => h.NativeCharacters).
//        FirstOrDefault();
//}

// Update a property on character

//using (AppDbContext context = new())
//{
//    var characterToUpdate = context.Characters.Where(c => c.FirstName == "Luke").FirstOrDefault();

//    characterToUpdate.FirstName = "Anakin";

//    context.Characters.Update(characterToUpdate);

//    context.SaveChanges();
//}

// Update a related property on character

//using (AppDbContext context = new())
//{
//    var newPlanet = context.Planets.Where(p => p.Name == "Dagobah").FirstOrDefault();
//    var characterToUpdate = context.Characters.Where(c => c.FirstName == "Anakin").FirstOrDefault();

//    characterToUpdate.HomePlanet = newPlanet;

//    context.Characters.Update(characterToUpdate);

//    context.SaveChanges();
//}