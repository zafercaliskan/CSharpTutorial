using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    ////naming convention
    class CartManager //CartService
    {
        //✓
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations. Added to cart: {0}", product.Name);
        }

        //×××
        public void Add2(string productName, string description, double price, int stockQuantity)
        {
            Console.WriteLine("Congratulations. Added to cart: {0}", productName);
        }
    }
}
