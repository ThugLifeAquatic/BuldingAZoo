using System;

namespace BuildZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler();
        }

        static void InputHandler()
        {
            Console.Clear();
            Falcon aBird = new Falcon();
            Ungulate aMammal = new Ungulate();
            Lizard aLizard = new Lizard();
            Console.WriteLine("Welcome to Austin's Strange Zoo!");
            Console.WriteLine("Enter a number to meet an animal.");
            Console.WriteLine("1. Meet a reptile.");
            Console.WriteLine("2. Meet a bird.");
            Console.WriteLine("3. Meet a mammal.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                ReptileInteraction(aLizard);
                InputHandler();
            }
            else if (input == "2")
            {
                BirdInteraction(aBird);
                InputHandler();
                
            }
            else if (input == "3")
            {
                MammalInteraction(aMammal);
                InputHandler();
            }
        }

        static void MammalInteraction(Mammal species)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {species.Species} pen!");
            Console.WriteLine($"Enter a number to interact with the {species.Species}!");
            Console.WriteLine("1. Learn about.");
            Console.WriteLine("2. Stare at.");
            Console.WriteLine("3. Poke.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"Family: {species.Family}");
                Console.WriteLine($"Diet: {species.Diet}");
                Console.WriteLine($"Habitat: {species.Habitat}");
                Console.ReadLine();
                MammalInteraction(species);
            }
            else if (input == "2")
            {
                Mammal.Stare(species.Species);
                Console.ReadLine();
                MammalInteraction(species);
            }
            else if (input == "3")
            {
                species.Attack(species.Species);
                Console.ReadLine();
                MammalInteraction(species);
            }
        }

        static void BirdInteraction(Bird species)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {species.Species} pen!");
            Console.WriteLine($"Enter a number to interact with the {species.Species}!");
            Console.WriteLine("1. Learn about.");
            Console.WriteLine("2. Stare at.");
            Console.WriteLine("3. Poke.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"Family: {species.Family}");
                Console.WriteLine($"Diet: {species.Diet}");
                Console.WriteLine($"Habitat: {species.Habitat}");
                Console.ReadLine();
                BirdInteraction(species);
            }
            else if (input == "2")
            {
                Bird.Stare(species.Species);
                Console.ReadLine();
                BirdInteraction(species);
            }
            else if (input == "3")
            {
                species.Attack(species.Species);
            }
        }

        static void ReptileInteraction(Reptile species)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {species.Species} pen!");
            Console.WriteLine($"Enter a number to interact with the {species.Species}!");
            Console.WriteLine("1. Learn about.");
            Console.WriteLine("2. Stare at.");
            Console.WriteLine("3. Poke.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"Family: {species.Family}");
                Console.WriteLine($"Diet: {species.Diet}");
                Console.WriteLine($"Habitat: {species.Habitat}");
                Console.ReadLine();
                ReptileInteraction(species);
            }
            else if (input == "2")
            {
                Reptile.Stare(species.Species);
                Console.ReadLine();
                ReptileInteraction(species);
            }
            else if (input == "3")
            {
                species.Attack(species.Species);
                Console.ReadLine();
                ReptileInteraction(species);
            }
        }
    }
}
