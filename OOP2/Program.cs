using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zafer Çalışkan
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = Guid.NewGuid();
            customer1.CustomerNo = "12312312";
            customer1.Name = "Zafer";
            customer1.Surname = "Çalışkan";
            customer1.TcNo = "1234567899";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = Guid.NewGuid();
            customer2.CustomerNo = "12312312";
            customer2.CompanyName="Kodlama.io";
            customer2.TaxNumber = "12312312";

            //Individual Customer - Corporate Customer
            //SOLID (L — Liskov substitution principle)

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            //Reference Type
            //The case here is Reference Type.

            //The event is that the base class (Customer) can hold the reference 
            //of IndividualCustomer and CorporateCustomer which inherit from it.

            //Base class is a reference holder.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}