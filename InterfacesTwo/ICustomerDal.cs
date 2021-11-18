using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTwo
{
    //Veritabanı işlemlerini yapacğaımız sınıf. Add, Delete, Update etc.
    //Burada oracle sql, ms sql her birinde kullanacağım teknoloji farklı.
    //Bunları implemente etmek için ayrı kodlar kullanmak gerekir. 
    interface ICustomerDal //Dal=> Data Access Layer Dao=> Data Access Object
    {
        void Add();
        void Update();
        void Delete();
    }

    //Simülasyon 
    //Burada 2 farklı sql var fakat ikiside ICustomerDaldan implement'e ediliyor. Referanslarını tutabilir.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql server added!");
        }

        public void Update()
        {
            Console.WriteLine("Sql server updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql server deleted!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated!");
        }
    }

    class CustomerManager
    {
        //Burada direk sql yada oracle'ı kullansaydık sadece o veri tabanına bağımlıyız.
        //Yani yeni bir müşteri veritabanım oracle dese biz sadece sql server destekliyoruz demek zorunda kaldırdık.
        public void Add(ICustomerDal customerDal) //Daha ileride consructordan alacağız. Dependency injection yapacağız.
        {
            //Böyle yaparsak sql server gönderirse onun içerisinde add çalışır. 
            //Oracle gönderirse onun içerisinde add methodu çalışır. Ikisinide desteklemiş oluruz.
            customerDal.Add();  //Burada ne sql ne oracle görüyoruz tamamen interface üzerinden gidiyor.
        }
    }
}

//Polymorphism: Bir nesneyi farklı amaçlarla implement edip o implementasyonların belirli bir kısmına yada tamamanına ulaşmaktır.
//Yukarıda Polymorphism yaptık. ICustomer dalı sqlserver  biçimnde yada oracle biçiminde implemente ettik.