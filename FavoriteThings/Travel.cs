using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Travel
    {
        public String Continent { get; set; }
        public String Destination { get; set; }
        public string Vehicle { get; set; }

        public Travel(string continent, string destination, string vehicle)
        {
            Continent = continent;
            Destination = destination;
            Vehicle = vehicle;
        }

        public void TravelMethod()
        {
            Console.WriteLine($"I am traveling by {Vehicle} to {Destination} which is located on {Continent}");
        }

        public void Rating()
        {
            Console.WriteLine("I give this trip 5 stars!!");
        }
    }

    
}
