using System;
using static Exercise3.Bird;
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


            // 3.3) Inherit 

            BirdPrinter.CreateAndOutputBirds();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Wolfman wolfman = new Wolfman("Alpha", 40, 4, true);

            Console.WriteLine($"\n Wolfman name: {wolfman.Name} Weights: {wolfman.Weight} Age: {wolfman.Age}");
            Console.ResetColor();
            wolfman.Talk();

            // 3.4) Polymorfism
             
            List<Animal> animals = new List<Animal>();

            animals.Add(new Horse("Thunder", 500, 5, "Black"));
            animals.Add(new Dog("Buddy", 30, 3, "Labrador"));
            animals.Add(new Hedgehog("Spike", 1, 2, 200));
            animals.Add(new Worm("Wiggly", 0.1, 1, false));
            animals.Add(new Wolf("Alpha", 40, 4, true));
            animals.Add(new Pelican("Pelican Pete", 15, 5, 250, 18.5));
            animals.Add(new Flamingo("Flora", 3.5, 6, 150, "Pink"));
            animals.Add(new Swan("Swan Song", 12, 7, 180, 30.0));

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Stats()}");
            }

            Console.ReadLine();


            try
            {
                handler.SetFirstName(person, "Mike");
                handler.SetLastName(person, "Tayson");
                handler.SetAge(person, 35);
                handler.SetHeight(person, 6.0);
                handler.SetWeight(person, 165);

                Console.WriteLine($"Updated Person: {person.FName} {person.LName}, Age: {person.Age} , Weight: {person.Weight}, Height: {person.Height}");

             /*   Person person1 = new Person();
                person1.PrintText("Hello Text");*/
            }
            catch (ArgumentException ex) when (ex.ParamName == "Age")
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArgumentException ex) when (ex.ParamName=="FName")
            {
                Console.WriteLine($"{ex.Message}");
            } catch (ArgumentException ex) when (ex.ParamName=="LName")
            {
                Console.WriteLine($"{ex.Message}");
            } catch (ArgumentException ex) when (ex.ParamName== "Weight")
            {
                Console.WriteLine($"{ex.Message}");
            } catch (ArgumentException ex) when (ex.ParamName== "Height")
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
