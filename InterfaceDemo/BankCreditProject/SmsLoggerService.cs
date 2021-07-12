using System;
using System.Collections.Generic;
using System.Text;

namespace BankCreditProject
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Müşteriye sms yollandı.");
        }
    }
}
