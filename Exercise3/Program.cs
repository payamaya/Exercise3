using System;
using static Animal;
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
            Animal.Wolfman wolfman = new Animal.Wolfman("\n Alpha", 40, 4, true);
            Console.WriteLine($"\n Wolfman name: {wolfman.Name}, Weights: {wolfman.Weight}, Age: {wolfman.Age}");
            wolfman.Talk();
            Console.ResetColor();


            // 3.3) Inherit 

          /*  BirdPrinter.CreateAndOutputBirds();
            DogPrinter.CreateAndOutputDogs();*/
          /*  Animal.CreateAndOutputAnimals();*/

            // 3.4) Polymorfism

            List<Animal> animals = new List<Animal>();
            animals.Add(new Pelican("Pelican", 12, 3, 20, 24));
            animals.Add(new Flamingo("Flamingo", 12, 3, 20, "Pin"));
            animals.Add(new Swan("Swan", 12, 3, 20, 34));

            animals.Add(new GermanShepherd("Rex", 12, 5, "German shepher", true));
            animals.Add(new Labrador("Max", 8, 1, "Labrador", "Golden"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nAnimal stats and sound\n");
            Console.ResetColor();

            foreach (var animal in animals)
            {

                Console.WriteLine($"{animal.Stats()} ,\x1b[31m \"Sound\" \x1b[0m :  {animal.DoSound()}");

                // Check if animal is of type IPerson
                if (animal is IPerson)
                {
                    Console.WriteLine($"This animal has IPerson interface: {animal}");
                    ((IPerson)animal).Talk();
                    Console.WriteLine("This animal can talk");
                }
                 if (animal is Bird bird)
                {
                   bird.Fly();
                    bird.Stats();   
                }
                 if(animal is Dog dog)
                {
                    dog.DoSound();
                }

                else
                {
                    Console.WriteLine("This animal cannot talk");
                }
                Console.WriteLine();

            }
           Animal.CreateAndOutputAnimals();

            /*     List<Bird> birds = Bird.CreateBirds();

                 foreach (var bird in birds)
                 {
                     Console.WriteLine($"{bird.Stats()}");
                 }


                 List<Animal.Dog> dogs = Dog.CreateDogs();

                 foreach (var dog in dogs)
                 {
                     Console.WriteLine($"{dog.Stats()}");
                 }*/

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
