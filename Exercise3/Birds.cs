using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{

    public abstract class Bird : Animals
    {
        public int WingSpan { get; set; }
        //Cannot be insyantiated
        public abstract void Fly();

        // constructor
        public Bird(string name, double weigth, int age, int wingSpan) : base(name, weigth, age)

        {
            WingSpan = wingSpan;
        }

        public override string DoSound() => "Chirp";

        public override string Stats() => $"{base.Stats()} , WingSpan: {WingSpan}";
    }

    public class Pelican : Bird
    {
        // Property unique.
        public double BeakLength { get; set; }
        // constructor
        public Pelican(string name, double weigth, int age, int wingSpan, double beakLength) : base(name, weigth, age, wingSpan)
        {
            BeakLength = beakLength;
        }
        public override void Fly() => Console.WriteLine($" {Name} is flying over the lake.");

        public override string Stats() => $"{base.Stats()} ,BeakLength: {BeakLength}";
    }

    public class Flamingo : Bird
    {
        // Property unique.
        public string Color { get; set; }
        // constructor
        public Flamingo(string name, double weigth, int age, int wingSpan, string color) : base(name, weigth, age, wingSpan)
        {
            Color = color;
        }
        public override void Fly() => Console.WriteLine($" {Name} is flying with grace!");

        public override string Stats() => $"{base.Stats()} ,Color: {Color}";
    }

    public class Swan : Bird
    {
        // Property unique.
        public double NeckLength { get; set; }
        // constructor
        public Swan(string name, double weigth, int age, int wingSpan, double neckLength) : base(name, weigth, age, wingSpan)
        {
            NeckLength = neckLength;
        }
        public override void Fly() => Console.WriteLine($" {Name} is flying elegantly!");

        public override string Stats() => $"{base.Stats()} ,NeckLength: {NeckLength}";
    }


}
