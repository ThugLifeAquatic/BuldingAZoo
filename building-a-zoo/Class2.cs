using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    abstract class Reptile : Animal
    {
        public bool HasLegs;

        public Reptile()
        {
            HasLegs = true;
        }

        public void Sound (string species)
        {
            Console.WriteLine($"The {species} hisses comfortingly.");
        }

        public void Stare(string species)
        {
            Console.WriteLine($"The {species} stares with its beady little eyes..");
        }

        public abstract void Attack(string species);
    }
}
