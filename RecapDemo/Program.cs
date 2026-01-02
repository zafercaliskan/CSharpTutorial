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

    //class Logger // If one leaves a class naked like this (without interface or base), be afraid of it. 
    //{ // Since it is like this, we can only 'new' it and use it.
    //    public void Log()
    //    {
    //        Console.WriteLine("Logged to database!"); // If another way of logging is requested tomorrow, we explode.
    //    }
    //}


    // Correct implementation
    // We used interface here because: Log method will contain different codes everywhere. No common code.
    // If Db and file were same and only sms changed, virtual could be used. Also valid for abstract classes.
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