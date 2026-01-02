using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTwo
{
    //Class where we will do database operations. Add, Delete, Update etc.
    //Here, oracle sql, ms sql, the technology I use in each is different.
    //Separate codes are required to implement these.
    interface ICustomerDal //Dal=> Data Access Layer Dao=> Data Access Object
    {
        void Add();
        void Update();
        void Delete();
    }

    //Simulation 
    //Here there are 2 different sqls but both are implemented from ICustomerDal. Can hold references.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql server added!");
        }

        public void Update()
        {
            Console.WriteLine("Sql server updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql server deleted!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated!");
        }
    }

    class CustomerManager
    {
        //If we used sql or oracle directly here, we would depend only on that database.
        //So if a new customer says my database is oracle, we would have to say we only support sql server.
        public void Add(ICustomerDal customerDal) //Later we will get it from constructor. We will do Dependency Injection.
        {
            //If we do this, if it sends sql server, add inside it works. 
            //If it sends Oracle, add method inside it works. We support both.
            customerDal.Add();  //Here we don't see sql or oracle, it completely goes through interface.
        }
    }
}

//Polymorphism: Implementing an object for different purposes and accessing a certain part or all of those implementations.
//We did Polymorphism above. We implemented ICustomerDal in the form of sqlserver or oracle.