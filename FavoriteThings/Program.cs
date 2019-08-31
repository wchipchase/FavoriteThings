using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var Maggie = new Pet(name: "Maggie", age: 4, color: "Red and White", isHairy: false);

            var Luna = new Pet(name: "Luna", age: 3, color: "Black", isHairy: true);

            Maggie.Stroke();
            Luna.Eat();

            var MDX = new Car(make: "Acura", model: "MDX", year: 2017, speed: 135);
            var Cayenne = new Car(make: "Porsche", model: "Cayenne", year: 1999, speed: 95);
            
            MDX.Drive();
            Cayenne.Park();

            var NoMansSky = new Games(name: "No Man's Sky", gameSystem: "PC", replay: false);
            var WoW = new Games(name: "World of Warcraft", gameSystem:"PC", replay: true);

            NoMansSky.Play();
            WoW.Play();
            WoW.Save();

            var Germany = new Travel("Europe", "Frankfurt", "Airplane");
            var Mexico = new Travel("South America", "Tijuana", "Automobile");

            Germany.TravelMethod();
            Mexico.TravelMethod();
            Mexico.Rating();
        }

    }
}
