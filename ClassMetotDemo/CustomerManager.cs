using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        //private readonly Db _db;
        public CustomerManager(/*Db db*/)
        {
            //_db = db;
        }
        public void List(Guid id)
        {
            //IQueryable<Customer> customers = _db.Customers.Where(x => x.CustomerId == customerId).OrderBy(x => x.CreatedOn);
            //return customers;

            Console.WriteLine($"List Function-> Id:{id}");
        }


        public void Create(Customer customer)
        {
            //customer.LastModifiedOn = DateTime.UtcNow;
            //_db.Entry(customer).State = EntityState.Added;
            //_db.SaveChanges();

            Console.WriteLine($"Create Function-> Name:{customer.Name}");
        }


        public void Update(Customer customer)
        {
            //var entry = _db.Entry(customer);
            //entry.State = EntityState.Modified;
            //_db.SaveChanges();

            Console.WriteLine($"Update Function-> Name:{customer.Name}");
        }

        public void Delete(Customer customer)
        {
            //_db.Customers.Remove(customer);
            //_db.SaveChanges();     

            Console.WriteLine($"Delete Function-> Name:{customer.Name}");
        }
    }
}