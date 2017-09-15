using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    abstract class Mammal : Animal
    {
        public bool CanClimb;

        public Mammal()
        {
            CanClimb = false;
        }

        public static void Sound(string species)
        {
            Console.WriteLine($"The {species} Wilhelm screams at you.");
        }

        public static void Stare(string species)
        {
            Console.WriteLine($"The {species} swishes its tail in slow motion.");
        }

        public abstract void Attack(string species);
    }
}
