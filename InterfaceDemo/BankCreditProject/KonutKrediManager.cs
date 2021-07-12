using System;
using System.Collections.Generic;
using System.Text;

namespace BankCreditProject
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
