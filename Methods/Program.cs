using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] products = new string[] { "Dell", "Asus" };

            Product product1 = new Product();
            product1.Id = new Guid();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.StockQuantity = 100;

            Product product2 = new Product()
            {
                Id = new Guid(),
                Name = "Samsung",
                Price = 20,
                StockQuantity = 200
            };

            Product[] products = new Product[] { product1, product2 };

            //type safe
            foreach (var product in products)
            {
                Console.WriteLine("Name:{0}\nPrice:{1}\n--------");
            }

            //instance
            CartManager cartManager = new CartManager();
            
            //encapsulation
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Asus", "Rog", 200, 50);
            cartManager.Add2("Dell", "Inspiron", 150, 25);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice