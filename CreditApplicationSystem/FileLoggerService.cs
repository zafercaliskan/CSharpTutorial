using System;
using System.Collections.Generic;
using System.Text;

namespace CreditApplicationSystem
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
