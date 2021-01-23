using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        //Property
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
    }
}