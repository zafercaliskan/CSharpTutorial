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
            //Classların bir diğer özelliğide property dediğimiz özellikleri tutmaktır.

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
            //Class nedir ne için kullanılır?
            //Yapmak istediğimiz işlemleri gruplara ayırmak. Bu grup üzerinden işlemlerimizi yapmak. 
            //Ve rahatlıkla bu gruba ulaşmak için kullanabiliriz en temel olarak. 

            //Classın örneği camelCase
            CustomerManager
                customerManager =
                    new CustomerManager(); //Aşağıdaki classın örneğini oluşturduk. Referansını da oluşturduk diyebiliriz.
            customerManager.Add();
            customerManager.Update();

            //ProductManager classının aynı dosyada bulunmasına gerek yok. 
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }

    //PascalCase
    class CustomerManager //Müşteriyle ilgili işlemleri koyabiliriz. CustomerManagerı başka bir dosyada da çalıştırabiliriz.
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