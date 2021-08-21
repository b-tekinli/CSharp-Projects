using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AtmApp.Enums;

namespace AtmApp
{
    public static class AtmOperations
    {
        public static Operations SendMoney(Person fwd, Person to, float amount)
        {
            if (amount > 0)
            {
                if (amount > fwd.balance)
                {
                    Logger.CreateFile(LogTypes.Fraud, fwd, null, "Hata: Para gönderme.");
                    return Operations.insufficientBalance;
                }
                else if (fwd.iban == to.iban)
                {
                    Logger.CreateFile(LogTypes.Fraud, fwd, null, "Hata: IBAN numaraları aynı!");
                    return Operations.insufficientBalance;
                }
                else
                {
                    fwd.balance -= amount;
                    to.balance += amount;
                    Logger.CreateFile(LogTypes.Transaction, fwd, to, $"Miktar: {amount} / Para transferi başarılı bir şekilde gerçekleşmiştir.");
                    return Operations.successfull;
                }
            }
            else
            {
                Logger.CreateFile(LogTypes.Fraud, fwd, null, "Hata: Geçersiz giriş!");
                return Operations.insufficientBalance;
            }
        }

        public static Person SendMoney()
        {
            Console.WriteLine("Para transferi yapacağınız IBAN numarasını giriniz: ");
            string iban = Console.ReadLine().Trim();

            return Program.persons.FirstOrDefault(x => x.iban == iban);
        }
    }
}
