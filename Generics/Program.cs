using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            MyList<string> myList = new MyList<string>();
            myList.Add("Zafer");
            myList.Add("Süleyman");

            Console.WriteLine(myList.Length);

            foreach (var item in myList.items)
            {
                Console.WriteLine(item);
            }
        }

        private static void Intro()
        {
            Utilities utilities = new Utilities();
            //                                       bu stringi vermesekde olurdu. başta T yi vermiştik.
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Antalya");
            //List<string> result = utilities.BuildList("Ankara", "İzmir", "Antalya");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList(new Customer {FirstName = "Zafer"},
                new Customer {FirstName = "Süleyman"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }

    class Utilities
    {
        // Whatever type we give as array, we can get as a list of that type.
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    // Generics point to a structure where we can say we will work with this object 
    // that we can change object-based operations we do frequently.

    // It doesn't matter if it is interface, class or abstract class, it is enough if we write nothing 
    // inside the <'Here'> part at the end of all of them. T is a nickname we give because of Type.
    // It can be anything we write with a capital letter. TEntity is also fine.

    // where T : struct ensures that only value types can be written.
    interface IRepository<T> where T : class, IEntity, new() // must be reference type and also must be newable. We ensured that only those implementing IEntity can be written so that they can write only db objects.
    // when we write class, we say it can be reference type. We cannot write int, it gives error because we said class but
    // we can write string because string is a reference type but behaves like value type.
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    //generic constrain(kısıt) product yazan yere string vs de yazılır onları kısıtlayabiliriz. 
    interface IProductDal : IRepository<Product>
    {

    }

    interface ICustomerDal : IRepository<Customer>
    {

    }

    interface IEntity
    {

    }

    class Product : IEntity
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }

    }

    class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}