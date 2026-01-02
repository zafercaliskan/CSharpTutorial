using System;

namespace Inheritance
{
    //Inheritance
    //Interfaces act like an example of inheritance, but they are not inheritance, they are implementation.
    //But they are used like inheritance in modern languages. 
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Zafer"
                },

                new Student
                {
                    FirstName = "Hasan"
                },

                // A general person definition can be made here. //Base class has a meaning.
                // It can be instantiated. But interfaces do not have a meaning on their own. They cannot be instantiated.
                new Person
                {
                    FirstName = "Süleyman"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            //? Should we use Interface or Inheritance?
            //- If we don't have to use Inheritance, it is better to walk through interfaces because interfaces can be used like inheritance. 
            //? So won't we use inheritance? 
            //- After looking at Abstract classes, it will become clear when to use interface and when to use inheritance.
        }
    }

    class Person //base class (We can think of it as the father of Customer and Student.)
    {
        //field 
        //public int Id; Property is used here, not field.

        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person //The important point here is we can only inherit once.
    //So it has one base class (every person has 1 father). But implementation can be done from multiple interfaces.
    //In order, inheritance is written first, then implementations can be done by separating with commas.
    {
        public string City { get; set; }
    }
    //Example.
    interface IPerson { }
    interface IPerson2 { }

    //A class can take multiple interfaces but a class can have 1 base class.
    class Student : Person, IPerson, IPerson2 //Inheritance is written first, then strictly interfaces.
    {
        public string Department { get; set; }
    }

    //Classes have a meaning on their own but interfaces do not have a meaning on their own. Both can be used like inheritance. 
    //Actually interfaces are an implementation. But in modern languages, their usage like inheritance is in question.

    //Important
    //Which one should we use? Inheritance is important for Abstract classes. 
    //If you can use interface, if you don't need inheritance or if you don't think you have to use it, we should use interface.
}