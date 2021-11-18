using System;

namespace Attributes
{
    class Program
    {
        //Attribute: Öznitelikler bir nesneye, birmethoda veya bir özelliğe kısaca c# yapılarına uygulayabileceğimiz ayrıca yapılardır.
        //Bu yapılar vasıtasıyla attributeuyguladığımız nesneye anlam katıyoruz. Kısaca Attributelar ile çalışma anında nesnelerinize veya
        //bu nesnelerin özelliklerine veya methodlara anlam katmak için Attributelardan yararlanırız.
        static void Main(string[] args)
        {
        }
    }

    //Burada parametreyi constructor ile set ederiz.
    [ToTable("Customers")] //Dbde Customers tabvlosuna denk gelir. Bunu dinamik sorgular üretmek için kullanırız. Alt zorunlu alanlarla birlikte. 
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty] //firstname'i girmesi zorunlu olsun. propertynin üzerine gelip anlam ifade edecek yapı kurabilirim. 
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        //Eski kullanılmamasını istediğimiz methodları Obsolete işaretleyip yenisini kullanmasına yönlendirebiliriz.
        [Obsolete("Dont use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added! ");
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added! ");
        }
    }

    //Attributelere de AttributeUsage ile attribute verebiliriz.
    //[AttributeUsage(AttributeTargets.All)] //Bu attribute'u herekese kullanabilirsin. ister class'a ister classın bir methoduna özelliğine heryerde kullabilirsin.
    //[AttributeUsage(AttributeTargets.Class)] //sadece classların üstüne eklenebilir.
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] //nesnelerin propertylerinde veya fieldlarda da kullanabiliriz.
    //[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] //Birden fazla kez üst üste yazıp yazamayacağımızı belirtiyoruz. 
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}