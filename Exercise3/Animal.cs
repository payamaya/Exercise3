
// Define the abstract Animal class.
using Exercise3;
using System.Drawing;
using System.Xml.Linq;

//Abstract so it can only be used as a based class

public abstract class Animals
{
    // Properties for Animal class.
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    // Constructor for the Animal class, taking name, weight, and age as parameters.
    protected Animals(string name, double weight, int age)
    {
        Name = name;
        Weight = weight;
        Age = age;
    }

    // Declare an abstract method DoSound to be implemented by derived classes.
    public abstract string DoSound();

    //3.4) Method return a string
    public virtual string Stats()
    {
        //String interpolation
        return $"\x1b[1;35m {Name} \x1b[0m: Weight: {Weight} kg, Age: {Age} years old";
    }

    // Static method to create and output animals.
    public static List<Animals> CreateAndOutputAnimals()
    {
        Console.WriteLine("\nAnimal List:");
        List<Animals> animals = new List<Animals>
            {
                new Horse("Thunder", 500, 5, "Black"),
                new Dog("Rander", 240, 5, "Black"),
                new Bird("Mander", 500, 5, 34),
                new Hedgehog("Spike", 1, 2, 200),
                new Worm("Wiggly", 0.1, 1, false),
                new Wolf("Alpha", 40, 4, true),
                new Wolfman("Derik",99,41, true)
            };

        foreach (var animal in animals)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(animal.Stats());
           
            Console.WriteLine($"\u001b[31m Animal Sound: \u001b[0m: {animal.DoSound()}");

            Console.ResetColor();
           
        }
        return animals;
    }

    // Define the Horse class which inherits from the Animal class.
    public class Horse : Animals
    {
        // Property unique to Horse.
        public string Color { get; set; }

        // Constructor for the Horse class, taking name, weight, age, and color as parameters.
        public Horse(string name, double weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Horse.

        public override string DoSound() => "Neigh";

        public override string Stats() => $"{base.Stats()}, Color:{Color}";

    }

    // Define the Dog class which inherits from the Animal class.
    public class Dog : Animals
    {
        // Property unique to Dog.
        public string Breed { get; set; }

        // Constructor for the Dog class, taking name, weight, age, and breed as parameters.
        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Dog.
        /*   public override string DoSound() {
               return "Bark";
           }
            public override string Stats()
           {
               return $"{base.Stats()}, Breed:{Breed}";
           } */
        public override string DoSound() => "Bark";

        public override string Stats() => $"{base.Stats()}, Breed:{Breed}";

    }    // Define the Dog class which inherits from the Animal class.
    public class Bird : Animals
    {
        // Property unique to Dog.
        public int WingSpan { get; set; }
        /* public abstract void Fly();*/

        // Constructor for the Dog class, taking name, weight, age, and breed as parameters.
        public Bird(string name, double weigth, int age, int wingSpan) : base(name, weigth, age)

        {
            WingSpan = wingSpan;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Bird.
        public override string DoSound() => "Chirp";

        public override string Stats() => $"{base.Stats()}, WingSpan: {WingSpan}";

    }

    // Define the Hedgehog class which inherits from the Animal class.
    public class Hedgehog : Animals
    {
        // Property unique to Hedgehog.
        public int NrOfSpikes { get; set; }

        // Constructor for the Hedgehog class, taking name, weight, age, and number of spikes as parameters.
        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Hedgehog.
        public override string DoSound() => "hog";

        public override string Stats() => $"{base.Stats()}, NrOfSpikes:{NrOfSpikes}";

    }

    // Define the Worm class which inherits from the Animal class.
    public class Worm : Animals
    {
        // Property unique to Worm.
        public bool IsPoisonous { get; set; }

        // Constructor for the Worm class, taking name, weight, age, and poisonous status as parameters.
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Worm.
        public override string DoSound() => "no sound";

        public override string Stats() => $"{base.Stats()}, IsPoisonous:{IsPoisonous}";

    }

    // Define the Wolf class which inherits from the Animal class.
    public class Wolf : Animals
    {
        // Property unique to Wolf.
        public bool IsPackLeader { get; set; }

        // Constructor for the Wolf class, taking name, weight, age, and pack leader status as parameters.
        public Wolf(string name, double weight, int age, bool isPackLeader) : base(name, weight, age)
        {
            IsPackLeader = isPackLeader;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Wolf.
        public override string DoSound() => "Howl";

        public override string Stats() => $"{base.Stats()}, IsPackLeader:{IsPackLeader}";

    }

    //------------------------Wolfman--------------------------------//

    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool isPackLeader) : base(name, weight, age, isPackLeader)
        {
        }

        public void Talk()
        {

            Console.WriteLine(" Wolfman say: I can sense your fear, but I mean no harm unless you threaten my pack.");

        }
        public override string Stats() => $"{base.Stats()}, IsPackLeader: {IsPackLeader}";

    }
}



