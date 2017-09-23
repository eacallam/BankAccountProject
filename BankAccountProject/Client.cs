using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //Required: 3 properties, 1 constructor, 1 method
        //Client information should be filled in here


        //FIELDS
        protected string firstName;
        protected string lastName;
        protected int age;

        //PROPERTIES
        public string FirstName
        {
            get { return this.firstName; }
            set { firstName = value;  }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { age = value; }
        }
        
        //CONSTRUCTOR
        public Client(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //METHODS
        public void DisplayInfo()
        {
            Console.WriteLine("Client Name: " + firstName + " " + lastName);
            Console.WriteLine("Client Age: " + age);
        }

    }
}
