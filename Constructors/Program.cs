using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CustomerManager customerManager = new CustomerManager(10);
            //() ile constructor'ın parametresiz bir şekilde çalıştırılması anlamına gelir.
            customerManager.List();

            Product product = new Product { Id = 1, Name = "laptop" }; //böylede kullanılır.
            Product product2 = new Product(1, "laptop"); //böylede kullanılır.

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger()); //Hangi logu kulancağımı söylemek zorundayz.
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10; //Dediğimizde herkes için aynı sonucu verir. Static nesneler ortak nesnelerdir.
            //Bir değer değiştiğinde herkes için değişmesini istiyorsak kullanmalıyız.
        }
    }

    class CustomerManager
    {
        //constructor başka nasıl tanımlanabilir? :
        //- Bu sınıfın ihtiyac duyduğu başka parametreler varsa ve kullanıma göre değişkenlik gösteriyorsa constructordan yararlanırız.

        private int _count = 10; //burası bir field. Burası _çizgi ile başlatılır. İsimlendirme kuralıdır. Default değer atadık.
        public CustomerManager(int count) //Burası overload edilebilir. Yani farklı parametrelerle oluşturabiliriz.
        {
            _count = count;
        }

        public CustomerManager() //Overload ettik.
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items!", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name) //Bu şekilde hızlıca değerleri set etmek adına da kullanılır.
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;  //Constructor ile gelen logger bu field'a eşitlenir. Methodlar içerisinde de bu field üzeirnden gidilir.
        //Değişim odaklı yazılımlarda olmazsa olmazdır. 
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    //------------------------

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass //Burası yani person manager diyor ki baseclass'ı newleyip kullanabilmem için entitye ihtiyacım var diyor.
    {
        public PersonManager(string entity) : base(entity)
        //Burada base'e entity'i gönderebiliriz. Yani personmanager parametreyi sadece base sınıf için aracılık edioyr..
        {
        }

        public void Add()
        {
            Console.WriteLine("Added!.");
            Message();
        }

        //Örnek: Soyut abstract sınıfımız var diyelim.
        //Abstract sınıfın içerisinde herşey standard sadece bir parametre değikenlik gösteriyor.
        //mesela connectionstring oracle,mysql vs farklıdır. connectionstring'i base parametre olarak gönderirsiniz.
        //Geriye kalan bütün işlemleri abstract sınıf yapar. 
    }

    //Static nesneler newlenemez yani instance'ı oluşturulamaz.//Arkaplanda sistem tarafından tek bir nesne oluşturulur. Bütün kullanıcılar tarafından tüketilir.
    static class Teacher //Paylaşılan bir kaynak olup olmadığından emin olmak lazım static kullanmak için.
    {
        public static int Number { get; set; }
    }

    static class Utilities //Geliştirdiğimiz ve heryerde kullanmamız geren methodları bu sınıf alınta toplayabiliriz.
    {
        static Utilities() //consructor
        {

        }
        public static void Validate() //Burada bir iş yap ve bitir.
        {
            Console.WriteLine("Validation is done!");
        }
    }

    class Manager //Bu şekil de kullanıabilir. Fakat burası static olsaydı tüm methodlar static olmak zorunda olurdu.
    {
        public static void DoSomething()//Burada Manager. diyerek çağırabiliriz.
        {

        }

        public void DoSomething2() //Burada instance luşturmak lazım yani newlemek gerekiyor Manager'ı bu methoda erişmek için.
        {

        }
    }
}