using System;
using static Animals;
using static Exercise3.Bird;
using static Exercise3.Dog;
using static Exercise3.UserError;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 3.1) Inkapsling Instansiera en person
            PersonHandler handler = new PersonHandler();
            Person person = handler.CreatePerson(30, "John", "Doe", 5.9, 160);
            Console.WriteLine($"Created Person: {person.FName} {person.LName}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");

            // 3.2 Polymorfism)
            List<UserError> errors = new List<UserError>
            {
              new NumericInputError(),
              new TextInputError(),
              new NullInputError(),
              new EmptyInputError(),
              new SpecialChracterInputError(),

            };

            foreach (UserError error in errors)
            {

                Console.WriteLine(error.UEMessage());
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Animals.Wolfman wolfman = new Animals.Wolfman("\n Alpha", 40, 4, true);
            Console.WriteLine($"\n Wolfman name: {wolfman.Name}, Weights: {wolfman.Weight}, Age: {wolfman.Age}");
            wolfman.Talk();
            Console.ResetColor();

            // 3.4) Polymorfism

            List<Animals> animalList = new List<Animals>();
            animalList.Add(new Horse("Thunder", 500, 5, "Black"));
            animalList.Add(new Pelican("Pelican", 12, 3, 20, 24));
            animalList.Add(new Flamingo("Flamingo", 12, 3, 20, "Pin"));
            animalList.Add(new Swan("Swan", 12, 3, 20, 34));
            animalList.Add(new Wolfman("Wolfy", 70, 35, true));
            animalList.Add(new GermanShepherd("Rex", 12, 5, "German shepher", true));
            animalList.Add(new Labrador("Max", 8, 1, "Labrador", "Golden"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAnimal stats and sound\n");
            Console.ResetColor();

            List<Dog> dogList = new List<Dog>();
            animalList.Add(new GermanShepherd("Shiva", 8, 3, "German shepher", true));
            animalList.Add(new Labrador("Stella", 6, 2, "Labrador", "Golden"));        
            //3.4) Mer polymorfism
            // Iterate over the list and output the stats of each animal
            foreach (var animal in animalList)
            {

                Console.WriteLine($"\u001b[31m Stats\u001b[0m:{animal.Stats()}.\n\x1b[31m Sound \x1b[0m: {animal.DoSound()}");
             
                if (animal is Bird bird)
                {
                    bird.Fly();
                    bird.Stats();
                }
              
                if (animal is Dog dogList1)
                {
                    Console.WriteLine($"\u001b[32m Stats For All Dogs\u001b[0m: {dogList1.Stats()}");
                    Console.WriteLine($"\u001b[32m Sound For All Dogs\u001b[0m: {dogList1.DoSound()}");
                    // 18) 
                    Console.WriteLine($" \u001b[32m{dogList1.Name}: \u001b[0m {dogList1.ReturnString()}" ); ;
                 
                }
                // Check if the animal implements IPerson and call the Talk method if it does
                if (animal is IPerson talk)
                {
                    talk.Talk();
                    //Wolfman is of type IPerson
                    Console.WriteLine($" This animal has \u001b[31m \"IPerson\"\u001b[0m interface, name: {animal.Name}");
                    Console.WriteLine($" This {animal.Name} can talk");
                }

                else
                {
                    Console.WriteLine($" The {animal.Name} cannot talk");
                    animal.Stats();
                }
                Console.WriteLine();

            };

            Animals.CreateAndOutputAnimals();
            Console.ReadLine();

            try
            {
                handler.SetFirstName(person, "Mike");
                handler.SetLastName(person, "Tayson");
                handler.SetAge(person, 35);
                handler.SetHeight(person, 6.0);
                handler.SetWeight(person, 165);

                Console.WriteLine($"Updated Person: {person.FName} {person.LName}, Age: {person.Age} , Weight: {person.Weight}, Height: {person.Height}");

            }
            catch (ArgumentException ex) when (ex.ParamName == "Age")
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArgumentException ex) when (ex.ParamName == "FName")
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArgumentException ex) when (ex.ParamName == "LName")
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArgumentException ex) when (ex.ParamName == "Weight")
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArgumentException ex) when (ex.ParamName == "Height")
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }

        }
    }
}

//Svara med kommentarer
/*
 1) F:  Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?

  I Bird Klassen

  2) F: Om alla djur behöver det nya attributet,vart skulle man lägga det då?
    I Animal Klassen



 3.4) Mer polymorfism

 9) F: försök att lägga till en häst i listan av hundar.Varför fungerar inte det? Cannot convert from 'Animal.Horse' to 'Exercise3.Dog'

 10) F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? 
  To store different types of animalList together, use a list of the base class type (Animal)

  Because 'Horse' is not a subclass of 'Dog'

 Argument 'number' cannot convert from TypeA to TypeB

The type of one argument in a method does not match the type that was passed when the class was instantiated.

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1502

  dogList.Add(new Horse("Shadowfax", 500, 5, "White")); 
  This will cause a compilation error. The reason is that the dogList is a list specifically for Dog objects, and Horse is not a Dog.

 * 13) F: Förklara vad det som händer.
 When we run the Program.cs we iterate over each animal in the animalList, for each animal we will call the Stats() method, which construct a string with animals detail and returns it,the Stats() methods in each subclass adds its own specific properties to the string returned by the base 'Animal' Console.WriteLine() will print out the returned string to the console.


 17) F: animal.ReturnString()
 Varför inte ? he compiler knows only about the members (methods, properties, etc.) defined in the Animal class and any of its base classes. It doesn't have knowledge of additional members that might be present in subclasses like Dog.

 */