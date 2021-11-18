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
        //Hangi Typeda array olarak verirsek o tipte liste olarak alabiliriz.
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    //Genericlerle biz sıklıkla yaptığımız operasyonları nesne bazlı olarak
    //değiştirebileceğimiz bu nesneyle çalışacağım diyebileceğimiz bir yapıya işaret eder.

    //interface, class veya abstract class'a farketmez hepsinin sonuna <'Buraya'> buraya
    //yazdığı kısım içerisine birşey yazmamış yeterli. T Typedan dolayı verdiğimiz bir takma ad.
    //Herhangi bir büyük harfle yazdığımız birşeyde olabilir. TEntity de olur.

    //where T : struct ise sadece değer tiplerin yazılmasını sağlar. 
    interface IRepository<T> where T : class, IEntity, new() //referans tip olmalı aynı zamanda newlenebilir olmalı. Sadece db nesnleri yazabilmeleri için IEntity den imp. olanların yazılmasını sağladık. 
    //class yazdığımız da referans tip olabilir demiş oluyoruz. int yazamayız hata verir class dediğimiz için ama
    //string yazarız çünkü string referans tiptir fakat değer tip gibi davranır.
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