using System;
using System.Collections.Generic;
using System.Text;

namespace CreditApplicationSystem
{

    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
