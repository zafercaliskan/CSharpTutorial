using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void StockControl(); //Eventler aslında bir delegedir. Delegelerin kullanımıyla yapılan bir işlemdir.
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                //stock 15 veya daha azsa ve kullanıcı bu ürüne abone olmuşsa
                if (value <= 15 && StockControlEvent != null) //StockControlEvent'e abone olduğunda nulldan farklı olur.
                {
                    StockControlEvent();
                }
            }
        }

        //Uygulamanın basitliği için koyuyoruz normalde Sell burada yazılmaz.
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine($"{ProductName} Stock amount: {Stock}");
        }
    }
}
