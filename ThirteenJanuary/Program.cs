using System;
using System.Collections.Generic;

namespace ThirteenJanuary
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Asus ROG Strix G17",
                Category = "Laptop",
                Price = 13999
            };

            Product product2 = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Mi 10T Pro",
                Category = "Phone",
                Price = 5799
            };

            List<Product> products = new List<Product>() { product1, product2 };

            login();

            Console.WriteLine("--for--");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Id:{products[i].Id} Name:{products[i].Name} Category:{products[i].Category} Price: {products[i].Price} TL");
            }

            Console.WriteLine("--foreach--");
            foreach (var product in products)
            {
                Console.WriteLine($"Id:{product.Id} Name:{product.Name} Category:{product.Category} Price: {product.Price} TL");
            }

            Console.WriteLine("--while--");
            int j = 0;
            while (j < products.Count)
            {
                Console.WriteLine($"Id:{products[j].Id} Name:{products[j].Name} Category:{products[j].Category} Price: {products[j].Price} TL");
                j++;
            }
        }

        static void login()
        {
            //string userId = "zafercaliskan", password = "123456";
            Console.Write("Id:");
            string userId = Console.ReadLine();

            if (userId == "zafercaliskan")
            {
                Console.Write("Password:");
                string password = Console.ReadLine();
                if (password == "123456")
                {
                    Console.WriteLine("You have successfully logged into the system.");
                }
                else
                {
                    ExitProgram("Incorrect password.");
                }
            }
            else
            {
                ExitProgram("Incorrect user id");
            }
        }
        static void ExitProgram(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            System.Environment.Exit(1);
        }
    }
}