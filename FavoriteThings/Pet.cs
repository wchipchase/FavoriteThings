using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Pet
    {
        

        public String Name { get; set; }
        public Int32 Age { get; set; }
        public String Color { get; set; }
        private bool _isHairy;

        public Pet(string name, int age, string color, bool isHairy)
        {
            Name = name;
            Age = age;
            Color= color;
            _isHairy = isHairy;
        }

        public void Stroke()
        {
            if (_isHairy == true)
            {
                Console.WriteLine($"{Name} is very fluffy with long, soft fur.");
            }
            else
            {
                Console.WriteLine($"{Name} is not too hairy, maybe they'd prefer a scritch?");
            }

        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is ready to eat now");
        }
    }


}
