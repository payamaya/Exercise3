using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Person
    {

        //Default constructor ctor=shortcut
      /*  //Constructor with no parameters is referres to as the default constructor
        public Person()
        {
            
        }*/

        //Declareing the backing field
        private int _age;
        private string _fName;
        private string _lName;
        private int _height;
        private int _weight;

   // Declare the property
        public int Age
        {
   //Add the getter and setter
            get {
            
                return _age;
            }
            set {

                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
                _age = value; 
            }

        }


        public string FName
        {
            get {
             

                return _fName;
            }

            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    Console.WriteLine("Fisrt name must be greater than 2 and less than 10");
                }
                _fName = value;

            } 
        }

        public string LName
        {
            get {
              
                return _lName; 
            }
            set 
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    Console.WriteLine("Last name must be greater than 3 and less than 15");
                }

                _lName = value; 
                
            }
        }
        public int Height
        {
            get {
                return _height; 
            }
            set { _height = value; }
        }
        public int Weight
        {
            get {
                return _weight; 
            }
            set { _weight = value; }
        }

        /* when overloaded contructor is defined the Default Constructor is not automatically created
         */
        
        public Person()
        {
            
        }
        // Overloaded Constructor ctor
        public Person(string fName, string lName, int age, int weight, int height)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }

    }
}
