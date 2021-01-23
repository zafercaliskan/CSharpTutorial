using System;

namespace OOP
{
    //(Object-Oriented Programming)
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Pencil",
                UnitPrice = 35
            };

            //case sensitive
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
            Console.WriteLine(product2.ProductName);

            //todo: Add example for ref and out
        }
    }
}