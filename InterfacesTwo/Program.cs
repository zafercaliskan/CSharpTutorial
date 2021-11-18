using System;

namespace InterfacesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo1();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            }; //İstediğim veri tabanı desteğini eklemek basit. 
            //ICustomerDal'dan implement ve içerisini doldurmak yeterli. Daha sonrasında
            //Buraya ekleyince oda çalışacaktır.

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo1()
        {
            CustomerManager customerManager = new CustomerManager();
            IPerson person = new Customer(); //Iperson newlenemez. soyut nesneler newlenmez.
            customerManager.Add(new OracleCustomerDal()); //Oracle kullandık.
            customerManager.Add(new SqlServerCustomerDal()); //Sql server kullandık. 
            //Yukarıda hiçbir yere müdahale etmeye gerek olmadan projemizi oracle yada sql destekli hale getirebiliyoruz.
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer()
            {
                Id = 1,
                FirstName = "Hasan",
                LastName = "Çalışkan",
                Address = "Açık adress..."
            });

            personManager.Add(new Student()
            {
                Id = 2,
                FirstName = "Zafer",
                LastName = "Çalışkan",
                Departmant = "Yazılım"
            });
        }
    }

    //Not: Interfacelerde temel nesne üzerindeki özelliklere erişilebilir. 
    // Interfaceleri daha çok servis implementasyonu yaparken veya katmanlar arası geçiş yaparken kullanırız.
    //Interface newlenemez. Instance'ı oluşturulamaz. Implement ettiği nesnelerin referanslarını tutabildiği için 
    //IPerson person = new Customer(); diyebiliriz.


    //Interface temel bir operasyon nesne oluşturup tüm nesneleri ondan implemente etmektir.
    interface IPerson
    {
        //Soyut nesne. Soyut nesneler tek başına bir anlam ifade etmezler.

        //interfaceler yazılırken sadece methodun imzası yazılır. 
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    //Bize lazım olan bir müşteriyle ve öğrenciyle ilgili işlem yapmaktır. Fakat
    //Müşteride öğrencide bir kişidir.

    //Somut nesne
    class Customer : IPerson
    {   //IPerson interface'inde yazılan method ve propertyleri implemente etmek gerekir.

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Müşterinin kendine has özellikleri olabilir.
        public string Address { get; set; }
    }

    //Somut nesne
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Öğrencinin kendine has özellikleri olabilir.
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        //Eğer böyle bir add methodu tanımlar sadece Customer nesnesi alırsak student için bu add'i kullanamayız.
        //Her nesne için add methodu yazmak gerekir. Onun yerine IPerson alsaydık. IPerson'ı implemente eden
        //Tüm nesneleri parametre olarak alabilir olacaktır. 
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirstName);
        //}

        public void Add(IPerson person) //Burası IPerson implement eden tüm nesneleri parametre olarak alabilir.
        {
            Console.WriteLine(person.FirstName); //Burada temel nesne üzerinde ne varsa onu kullanabiliriz sadece.
            //örneğin customerdaki adres bilgisiyle studentdaki departman bilgisine erişemeyiz.
        }
    }
}