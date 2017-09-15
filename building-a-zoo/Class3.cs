using System;
using System.Collections.Generic;
using System.Text;

namespace BuildZoo
{
    class Lizard : Reptile
    {
        public Lizard ()
        {
            HasLegs = true;
            Family = "reptile";
            Species = "iguana";
            Diet = "hebivore";
            Habitat = "tropical";
            IsDead = false;
        }

        public override void Attack(string species)
        {
            Console.WriteLine($"The {species} soothingly latches onto your face and whipps you with its tail.");
        }
    }
}
