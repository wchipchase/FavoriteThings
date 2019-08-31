using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public short Year { get; set; }
        public int Speed { get; set; }

        public Car(string make, string model, short year, int speed)
        {
            Make = make;
            Model = model;
            Year = year;
            Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm driving my {Year } {Make} {Model} at approximately {Speed}mph");
        }

        public void Park()
        {
            Console.WriteLine($"I am parking the {Make} {Model} now");
        }
    }
}
