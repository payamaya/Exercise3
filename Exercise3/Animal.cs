
// Define the abstract Animal class.
using Exercise3;

public abstract class Animal
    {
        // Properties for Animal class.
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        // Constructor for the Animal class, taking name, weight, and age as parameters.
        protected Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        // Declare an abstract method DoSound to be implemented by derived classes.
        public abstract string DoSound();
    }

    // Define the Horse class which inherits from the Animal class.
    public class Horse : Animal
    {
        // Property unique to Horse.
        public string Color { get; set; }

        // Constructor for the Horse class, taking name, weight, age, and color as parameters.
        public Horse(string name, double weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Horse.
        public override string DoSound()
        {
            return "Neigh";
        }
    }

    // Define the Dog class which inherits from the Animal class.
    public class Dog : Animal
    {
        // Property unique to Dog.
        public string Breed { get; set; }

        // Constructor for the Dog class, taking name, weight, age, and breed as parameters.
        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Dog.
        public override string DoSound()
        {
            return "Bark";
        }
    }

    // Define the Hedgehog class which inherits from the Animal class.
    public class Hedgehog : Animal
    {
        // Property unique to Hedgehog.
        public int NrOfSpikes { get; set; }

        // Constructor for the Hedgehog class, taking name, weight, age, and number of spikes as parameters.
        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Hedgehog.
        public override string DoSound()
        {
            return "hog";
        }
    }

    // Define the Worm class which inherits from the Animal class.
    public class Worm : Animal
    {
        // Property unique to Worm.
        public bool IsPoisonous { get; set; }

        // Constructor for the Worm class, taking name, weight, age, and poisonous status as parameters.
        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Worm.
        public override string DoSound()
        {
            return "no sound";
        }
    }

    // Define the Wolf class which inherits from the Animal class.
    public class Wolf : Animal
    {
        // Property unique to Wolf.
        public bool IsPackLeader { get; set; }

        // Constructor for the Wolf class, taking name, weight, age, and pack leader status as parameters.
        public Wolf(string name, double weight, int age, bool isPackLeader) : base(name, weight, age)
        {
            IsPackLeader = isPackLeader;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Wolf.
        public override string DoSound()
        {
            return "Howl";
        }
    }

             //------------------------Wolfman--------------------------------//
             
public class Wolfman:IPerson
{
    public void Talk()
    {
        Console.WriteLine("Hello people");
    }
}




//Svara med kommentarer
/*
 1)  Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?

  2) Om alla djur behöver det nya attributet,vart skulle man lägga det då?

 */





    // Define the abstract Bird class which inherits from the Animal class.
    public abstract class Bird : Animal
    {
        // Property unique to Bird.
        public int WingSpan { get; set; }

        // Declare an abstract method Fly to be implemented by derived classes.
        public abstract void Fly();

        // Constructor for the Bird class, taking name, weight, age, and wingspan as parameters.
        protected Bird(string name, double weight, int age, int wingSpan) : base(name, weight, age)
        {
            // Initialize the WingSpan property with the value passed to the constructor.
            WingSpan = wingSpan;
        }

        // Override the abstract DoSound() method from the Animal class to provide specific implementation for Birds.
        public override string DoSound()
        {
            return "Chirp";
        }

        // Define the Pelican class which inherits from the Bird class.
        public class Pelican : Bird
        {
            // Property unique to Pelican.
            public double BeakLength { get; set; }

            // Constructor for the Pelican class, taking name, weight, age, wingspan, and beak length as parameters.
            public Pelican(string name, double weight, int age, int wingSpan, double beakLength) : base(name, weight, age, wingSpan)
            {
                // Initialize the BeakLength property with the value passed to the constructor.
                BeakLength = beakLength;
            }

            // Override the abstract Fly method from the Bird class to provide specific implementation for Pelican.
            public override void Fly()
            {
                Console.WriteLine("Pelican is flying over the lake.");
            }
        }

        // Define the Flamingo class which inherits from the Bird class.
        public class Flamingo : Bird
        {
            // Property unique to Flamingo.
            public string Color { get; set; }

            // Constructor for the Flamingo class, taking name, weight, age, wingspan, and color as parameters.
            public Flamingo(string name, double weight, int age, int wingSpan, string color) : base(name, weight, age, wingSpan)
            {
                // Initialize the Color property with the value passed to the constructor.
                Color = color;
            }

            // Override the abstract Fly method from the Bird class to provide specific implementation for Flamingo.
            public override void Fly()
            {
                Console.WriteLine("Flamingo is flying with grace!");
            }
        }

        // Define the Swan class which inherits from the Bird class.
        public class Swan : Bird
        {
            // Property unique to Swan.
            public double NeckLength { get; set; }

            // Constructor for the Swan class, taking name, weight, age, wingspan, and neck length as parameters.
            public Swan(string name, double weight, int age, int wingSpan, double neckLength) : base(name, weight, age, wingSpan)
            {
                // Initialize the NeckLength property with the value passed to the constructor.
                NeckLength = neckLength;
            }

            // Override the abstract Fly method from the Bird class to provide specific implementation for Swan.
            public override void Fly()
            {
                Console.WriteLine("Swan is flying elegantly!");
            }
        }
    }
