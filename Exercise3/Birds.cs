using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{

    public abstract class Bird : Animal
    {
        public int WingSpan { get; set; }
        public abstract void Fly();

        public Bird(string name, double weigth, int age, int wingSpan) : base(name, weigth, age)

        {
            WingSpan = wingSpan;
        }

        public override string DoSound()
        {
            return "Chirp";
        }
        public override string Stats()
        {
            return $"{base.Stats()} ,WingSpan:{WingSpan}";
        }

        /* public static List<Bird> CreateBirds()
         {
             List<Bird> birds = new List<Bird>();
             Console.WriteLine("\nBird List");
             birds.Add(new Pelican("¨Pelican",12,3,20,24));
             birds.Add(new Flamingo("Flamingo",12,3,20,"Pin"));
             birds.Add(new Swan("Swan",12,3,20,34));

             return birds;
         }*/
    }
    public class Pelican : Bird
    {
        public double BeakLength { get; set; }
        public Pelican(string name, double weigth, int age, int wingSpan, double beakLength) : base(name, weigth, age, wingSpan)
        {
            BeakLength = beakLength;
        }
        /* public override void Fly()
         {
             Console.WriteLine("Pelican is flying over the lake.");
         }  */
        /*public override string Stats()
        {
            return $"{base.Stats()} ,BeakLength:{BeakLength}";
        }*/
        public override void Fly() => Console.WriteLine("Pelican is flying over the lake.");

        public override string Stats() => $"{base.Stats()} ,BeakLength:{BeakLength}";
    }
    public class Flamingo : Bird
    {
        public string Color { get; set; }

        public Flamingo(string name, double weigth, int age, int wingSpan, string color) : base(name, weigth, age, wingSpan)
        {
            Color = color;
        }
        public override void Fly() => Console.WriteLine("Flamingo is flying with grace!");

        public override string Stats() => $"{base.Stats()} ,Color:{Color}";

    }
    public class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, double weigth, int age, int wingSpan, double neckLength) : base(name, weigth, age, wingSpan)
        {
            NeckLength = neckLength;
        }
        public override void Fly() => Console.WriteLine("Swan is flying elegantly!");

        public override string Stats() => $"{base.Stats()} ,NeckLength:{NeckLength}";

    }


}
