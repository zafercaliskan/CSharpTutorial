using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassIntro();
            //DefinePropertyInClass();
        }

        private static void DefinePropertyInClass()
        {
            //Another feature of classes is to hold features we call property.

            //Example 1
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Zafer";
            customer.LastName = "Çalışkan";
            customer.City = "Antalya";

            //Example 2
            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Hasan",
                LastName = "Çalışkan",
                City = "Antalya"
            };

            Console.WriteLine(customer2.FirstName);
        }

        private static void ClassIntro()
        {
            //What is a Class and what is it used for?
            //To separate the operations we want to do into groups. To do our operations over this group. 
            //And fundamentally we can use it to reach this group easily. 

            //Class instance camelCase
            CustomerManager
                customerManager =
                    new CustomerManager(); //We created an instance of the class below. We can also say we created its reference.
            customerManager.Add();
            customerManager.Update();

            //ProductManager class does not need to be in the same file. 
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }

    //PascalCase
    class CustomerManager //We can put operations related to customer. We can also run CustomerManager in another file.
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}