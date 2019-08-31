using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Games
    {
        public string Name { get; set; }
        public string GameSystem { get; set; }
        public bool Replay { get; set; }

        public Games(string name, string gameSystem, bool replay)
        {
            Name = name;
            GameSystem = gameSystem;
            Replay = replay;
        }

        public void Play()
        {
            if (Replay == true)
            {
                Console.WriteLine($"I am playing {Name} on the {GameSystem}. I'd like to play this game again..");
            }
            else
            {
                Console.WriteLine(($"{Name} sucked, I don't want to play it again"));
            }
        }

        public void Save()
        {
            Console.WriteLine("Save is in progress");
        }
    }
}
