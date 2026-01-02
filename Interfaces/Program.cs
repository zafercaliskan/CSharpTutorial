using System;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            //interfaces cannot be instantiated.
            //IPersonManager personManager = new IPersonManager();

            //IPersonManager customerManager = new CustomerManager(); //Interfaces are reference types. A reference value of CustomerManager is created in Heap.
            //IPersonManager can also hold this reference value. So interfaces can hold the reference number of the class that implements it (new CustomerManager();).

            IPersonManager customerManager = new CustomerManager(); //Holds CustomerManager reference.
            customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager(); //Holds EmployeeManager reference.
            employeeManager.Add();

        }
    }

    //class PersonManager
    //{
    //    //implemented operation
    //    public void Add() //PersonManager Add operation means it is common everywhere. The code written inside is common everywhere.
    //    {
    //        Console.WriteLine("Added");
    //    }
    //}
    //class CustomerManager : PersonManager
    //{
    //    //We said CustomerManager can use the operations of the base class it inherited in addition to its own operations.
    //}

    interface IPersonManager //We determine the template. It has to use void Add() signature but can write its own codes.
    {
        //unimplemented operation
        void Add(); //Default is public. We don't fill it here. My signature can be the same but it contains separate codes for CustomerManager and EmployeeManager.
        void Update();
    }

    //inherits-class ------ implements-interface
    class CustomerManager : IPersonManager //These also have to comply with the template. Signatures are the same. Code contents are different. This is also IPersonManager.
    {
        public void Add() //Here signatures are the same but codes inside are different.
        {
            //Customer add codes
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated.");
        }
    }

    class EmployeeManager : IPersonManager //These also have to comply with the template. Signatures are the same. Code contents are different. This is also IPersonManager.
    {
        public void Add()
        {
            //Personnel add codes 
            Console.WriteLine("Personnel added.");
        }

        public void Update()
        {
            Console.WriteLine("Personnel updated.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern added.");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated.");
        }
    }

    class ProjectManager
    {
        //You always work with multiple objects, not a single one. That's why the usage here is creating a wrong pattern.
        //public void AddCustomer(CustomerManager customerManager) //Wrong
        //{
        //    customerManager.Add();
        //}

        //public void AddEmployee(EmployeeManager employeeManager) //Wrong
        //{
        //    employeeManager.Add();
        //}

        public void Add(IPersonManager personManager)
        //Takes interface as parameter. All classes implemented from IPersonManager can be sent here.
        //This place accepts IPersonManager. And it accepts all classes implemented from IPersonManager.
        //This provides us change in software. Very basic principle in software is existing codes are not touched when you add a new feature.
        //While CustomerManager and EmployeeManager exist, we add InternManager and implement from IPersonManager, write our own operation codes (Add, Update).
        //But we don't need to change anything for ProjectManager because it accepts IPersonManager. Since InternManager is also implemented from IPersonManager
        //it will accept.
        
        //********* The biggest problem in software is the customer making new requests 3 months after you write the project. *********
        {
            personManager.Add();
        }
    }
}