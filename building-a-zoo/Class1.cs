using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    abstract class Animal
    {
        public string Species;
        public string Family;
        public string Diet;
        public string Habitat;
        public bool IsDead = false;

        public Animal()
        {
            Species = "Unknown";
            Family = "Unknown";
            Diet = "Unknown, but probably humans.";
            Habitat = "Unknown";
            IsDead = false;
        }

        public static void Eats(string species)
        {
            Console.WriteLine($"The {species} eats.");
        }

        public static void Sleeps(string species)
        {
            Console.WriteLine($"The {species} goes to sleep.");
        }

        public void GetsDead(string species)
        {
            Console.WriteLine($"The {species} becomes dead.");
            IsDead = true;
        }
    }
}
