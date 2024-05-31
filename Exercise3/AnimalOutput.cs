/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class AnimalOutput
    {
        public void CreateAndOutputAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Section 3 inherit Animal");
            Console.ResetColor();
            // Create an instance of Horse and call its methods
            Horse horse = new Horse("Thunder", 500, 5, "Black");
            Console.WriteLine($"Horse: {horse.Name}, Weight: {horse.Weight}, Age: {horse.Age}, Color: {horse.Color}");
            Console.WriteLine($"Horse Sound: {horse.DoSound()}");

            // Create an instance of Dog and call its methods
            Dog dog = new Dog("Buddy", 30, 3, "Labrador");
            Console.WriteLine($"\nDog: {dog.Name}, Weight: {dog.Weight}, Age: {dog.Age}, Breed: {dog.Breed}");
            Console.WriteLine($"Dog Sound: {dog.DoSound()}");

            // Create an instance of Hedgehog and call its methods
            Hedgehog hedgehog = new Hedgehog("Spike", 1, 2, 200);
            Console.WriteLine($"\nHedgehog: {hedgehog.Name}, Weight: {hedgehog.Weight}, Age: {hedgehog.Age}, NrOfSpikes: {hedgehog.NrOfSpikes}");
            Console.WriteLine($"Hedgehog Sound: {hedgehog.DoSound()}");

            // Create an instance of Worm and call its methods
            Worm worm = new Worm("Wiggly", 0.1, 1, false);
            Console.WriteLine($"\nWorm: {worm.Name}, Weight: {worm.Weight}, Age: {worm.Age}, IsPoisonous: {worm.IsPoisonous}");
            Console.WriteLine($"Worm Sound: {worm.DoSound()}");

            // Create an instance of Wolf and call its methods
            Wolf wolf = new Wolf("Alpha", 40, 4, true);
            Console.WriteLine($"\nWolf: {wolf.Name}, Weight: {wolf.Weight}, Age: {wolf.Age}, IsPackLeader: {wolf.IsPackLeader}");
            Console.WriteLine($"Wolf Sound: {wolf.DoSound()}");

            // Create an instance of Pelican and call its methods
            Bird.Pelican pelican = new Bird.Pelican("Pelican Pete", 15, 5, 250, 18.5);
            Console.WriteLine($"\nPelican: {pelican.Name}, Weight: {pelican.Weight}, Age: {pelican.Age}, WingSpan: {pelican.WingSpan}, BeakLength: {pelican.BeakLength}");
            Console.WriteLine($"Pelican Sound: {pelican.DoSound()}");
            pelican.Fly();

            // Create an instance of Flamingo and call its methods
            Bird.Flamingo flamingo = new Bird.Flamingo("Flora", 3.5, 6, 150, "Pink");
            Console.WriteLine($"\nFlamingo: {flamingo.Name}, Weight: {flamingo.Weight}, Age: {flamingo.Age}, WingSpan: {flamingo.WingSpan}, Color: {flamingo.Color}");
            Console.WriteLine($"Flamingo Sound: {flamingo.DoSound()}");
            flamingo.Fly();

            // Create an instance of Swan and call its methods
            Bird.Swan swan = new Bird.Swan("Swan Song", 12, 7, 180, 30.0);
            Console.WriteLine($"\nSwan: {swan.Name}, Weight: {swan.Weight}, Age: {swan.Age}, WingSpan: {swan.WingSpan}, NeckLength: {swan.NeckLength}");
            Console.WriteLine($"Swan Sound: {swan.DoSound()}");
            swan.Fly();

            Console.ReadKey();
        }
    }
}
*/