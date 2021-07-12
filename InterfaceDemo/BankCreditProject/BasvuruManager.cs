<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankCreditProject
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            // 
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankCreditProject
{
    class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            // 
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
>>>>>>> 5d07406a97d5525537787655630dbdd687a24c2c
