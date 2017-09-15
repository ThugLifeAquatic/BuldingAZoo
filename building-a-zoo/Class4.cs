using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    abstract class Bird : Animal
    {
        public bool CanFly;

        public Bird()
        {
           CanFly  = true;
        }

        public static void Sound(string species)
        {
            Console.WriteLine($"The {species} squawks, like, super loud.");
        }

        public static void Stare(string species)
        {
            Console.WriteLine($"The {species} stares directly back at you, and lays an egg.");
        }

        public abstract void Attack(string species);
    }
}
