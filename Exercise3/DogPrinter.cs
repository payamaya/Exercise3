/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class DogPrinter

    {
       public static void CreateAndOutputDogs()

       {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n 3.3) Inherit Dog Output description");
            Console.ResetColor();

            // Create an instance of Dog and call its methods

            GermanShepherd germanDog = new GermanShepherd("German Rex ", 15, 5,"German Shepher", true);

           Console.WriteLine($"\nGerman: {germanDog.Name}, Weight: {germanDog.Weight}, Age: {germanDog.Age}, Breed: {germanDog.Breed}, IsPoliceDog: {germanDog.IsPoliceDog}");
            Console.WriteLine($"germanDog Sound: {germanDog.DoSound()}");
            germanDog.DoSound(); 


            Labrador labradorDog = new Labrador("Flamingo Flamyo", 12, 2, "brown and black", "Labrador");

            Console.WriteLine($"\nLabrador: {labradorDog.Name}, Weight: {labradorDog.Weight}, Age: {labradorDog.Age}, Breed: {labradorDog.Breed}, IsPoliceDog: {labradorDog.Color}");
            Console.WriteLine($"Labrador Sound: {labradorDog.DoSound()}");
            labradorDog.DoSound();

            
         
       }
    }
}
*/