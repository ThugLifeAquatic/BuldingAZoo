using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    class Ungulate : Mammal
    {
        public Ungulate()
        {
            CanClimb = true;
            Family = "Mammal";
            Species = "Giraffe";
            Diet = "Carnivore";
            Habitat = "Savannah";
            IsDead = false;
        }

        public override void Attack(string species)
        {
            Console.WriteLine($"The {species} shoots its tongue out like a chameleon and steals your pizza.");
        }
    }
}
