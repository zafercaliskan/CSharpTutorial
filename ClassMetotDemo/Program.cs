using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = Guid.NewGuid();
            customer1.Name = "Zafer";
            customer1.Surname = "Çalışkan";            

            Customer customer2 = new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Süleyman",
                Surname = "Çalışkan"
            };

            CustomerManager customerManager = new CustomerManager();

            //Create
            customerManager.Create(customer1);

            //Update
            customerManager.Update(customer2);

            //Delete
            customerManager.Delete(customer2);

            //List
            /*var customers =*/ customerManager.List(Guid.NewGuid());
        }
    }
}