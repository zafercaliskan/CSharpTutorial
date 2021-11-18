using System;

namespace RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager1 = new CustomerManager(new DatabaseLogger());
            customerManager1.Add();

            CustomerManager customerManager2 = new CustomerManager(new FileLogger());
            customerManager2.Add();

            CustomerManager customerManager3 = new CustomerManager(new SmsLogger());
            customerManager3.Add();
        }
    }

    class CustomerManager
    {
        private readonly ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Customer added! \n");
        }
    }

    //class Logger //Bir class'ı böyle çıplak bırakınca (9interface'i yada base'i yoksa) bundan kork. 
    //{ //Bu böyle olduğu için sadece newleyip kullanabiliriz.
    //    public void Log()
    //    {
    //        Console.WriteLine("Logged to database!"); //Yarın birgün başka şekilde logllama istenirse patlarız.
    //    }
    //}


    //Doğru implementasyon
    //Burada interface kullandık çünkü: Heryerde Log methodu farklı kodlar içerecek. Ortak kod yok.
    //Db file aynı olsaydı sadece smsde değişseydi virtual yapılabilirdi. Abstract sınıflar içinde geçerli.
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

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
}