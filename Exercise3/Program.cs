namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Instansiera en person
            // Person person = new Person("paul","Yashouh",34,87,188);    
            Person person = new Person();



            try
            {
                person.Age = 25;
                person.FName = "Pa";
                person.LName = "YA";
                person.Weight = 80;
                person.Height = 188;
                
                Console.WriteLine($"Age: " + person.Age);
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
