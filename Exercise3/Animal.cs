using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract double Weight { get; }
        public abstract int Age { get; }

        public abstract string DoSound();
    }
     
/*    public class Horse : Animal
    {
     
    }

    public class Dog : Animal
    {

    }
    public class Hedgehog : Animal
    {

    }
    public class Worm : Animal
    {

    }
    public class Bird : Animal
    {

    }
    public class Wolf : Animal
    {

    }*/
}
