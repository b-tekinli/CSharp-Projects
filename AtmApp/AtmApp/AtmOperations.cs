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
                else if (fwd.IBAN == to.IBAN)
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
    }
}
