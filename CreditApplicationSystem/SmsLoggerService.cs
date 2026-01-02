using System;
namespace CreditApplicationSystem
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms sent");
        }
    }
}
