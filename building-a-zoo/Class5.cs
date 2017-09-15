using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    class Falcon : Bird
    {
        public Falcon()
        {
            CanFly = true;
            Family = "bird";
            Species = "Perigrine Falcon";
            Diet = "carnivore";
            Habitat = "temperate";
            IsDead = false;
        }

        public override void Attack(string species)
        {
            Console.WriteLine($"The {species} rockets to the ground at near lightspeed, and on impact, levels the entire zoo.");
            Console.WriteLine("Simulation over. You have destroyed the zoo.");
            Console.Read();
            Environment.Exit(1);
        }
    }
}
