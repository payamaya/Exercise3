using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetFirstName(Person person, string firstName)
        {
            if (string.IsNullOrEmpty(firstName) || firstName.Length < 2 || firstName.Length > 10)
            {
                throw new ArgumentException("First name must be between 2 and 10 characters.");
            }
            person.FName = firstName;
        }

        public void SetLastName(Person person, string lastName)
        {
            if(string.IsNullOrEmpty(lastName) || lastName.Length < 3 || lastName.Length > 10) 
            {
                throw new ArgumentException("Last name must be between 3 and 15 characters");            
            }
            person.LName = lastName;
        }

        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }
        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person();
            SetAge(person, age);
            SetFirstName(person,fName);
            SetLastName(person,lName);
            SetWeight(person,weight);
            SetHeight(person,height);

            return person;
        }

    }

}
