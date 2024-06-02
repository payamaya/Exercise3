using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{

    public abstract class Dog : Animals
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override string Stats() => $"{base.Stats()}, Breed: {Breed}";

        public virtual string ReturnString()
        {
            return $"New method that return only string";
        }

    }
    public class GermanShepherd : Dog
    {
        public bool IsPoliceDog { get; set; }

        public GermanShepherd(string name, double weight, int age, string breed, bool isPoliceDog) : base(name, weight, age, breed)
        {
            IsPoliceDog = isPoliceDog;
        }

        public override string Stats() => $"{base.Stats()}, IsPoliceDog: {IsPoliceDog}";

        public override string DoSound() => "Barkk";
    }

    public class Labrador : Dog
    {
        public string Color { get; set; }

        public Labrador(string name, double weight, int age, string breed, string color) : base(name, weight, age, breed)
        {
            Color = color;
        }

        public override string Stats() => $"{base.Stats()}, Color: {Color}";

        public override string DoSound() => "BBark";
    }
  

}