using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class BirdPrinter
    {
        public static void CreateAndOutputBirds()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n 3.3) Inherit Bird Output description");
            Console.ResetColor();

            // Create an instance of Bird and call its methods

            Bird.Pelican pelican = new Bird.Pelican("Pelican Pete", 15, 5, 150, 18.5);

            Console.WriteLine($"\nPelican: {pelican.Name}, Weight: {pelican.Weight}, Age: {pelican.Age}, WingSpan: {pelican.WingSpan}, BeakLength: {pelican.BeakLength}");
            Console.WriteLine($"Pelican Sound: {pelican.DoSound()}");
            pelican.Fly(); 


            Bird.Flamingo flamingo = new Bird.Flamingo("Flamingo Flamyo", 25, 6, 180, "Pink");

            Console.WriteLine($"\nFlamingo: {flamingo.Name}, Weight: {flamingo.Weight}, Age: {flamingo.Age}, WingSpan: {flamingo.WingSpan}, Color: {flamingo.Color}");
            Console.WriteLine($"flamingo Sound: {flamingo.DoSound()}");
            flamingo.Fly();

            
            Bird.Swan Swan = new Bird.Swan("Swan Bella", 18, 7, 120, 75);

            Console.WriteLine($"\nSwan: {Swan.Name}, Weight: {Swan.Weight}, Age: {Swan.Age}, WingSpan: {Swan.WingSpan}");
            Console.WriteLine($"Swan Sound: {Swan.DoSound()}");
            Swan.Fly();
            
        }
    }
}
