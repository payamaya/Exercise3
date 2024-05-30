using System;
using static Exercise3.UserError;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           
            //Instansiera en person
            // Person person = new Person("paul","Yashouh",34,87,188);    
            /*      Person person = new Person();*/
            // 1.)
            PersonHandler handler = new PersonHandler();

            // 2.)
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

            // 3.)
         
          
            AnimalOutput animalOutput = new AnimalOutput();
            animalOutput.CreateAndOutputAnimals();
            Console.ReadLine();

            try
            {
                Person person = handler.CreatePerson(30, "John", "Doe", 5.9, 160);
                Console.WriteLine($"Created Person: {person.FName} {person.LName}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");

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
