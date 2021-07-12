using System;
using System.Collections.Generic;
using System.Text;

namespace BankCreditProject
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
