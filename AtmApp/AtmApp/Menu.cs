using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public static class Menu
    {
        private static Dictionary<int, string> menu = new Dictionary<int, string>();
        public static byte OperationMenu()
        {
            if (menu.Count < 4)
            {
                menu.Add(1, "Para Çekme");
                menu.Add(2, "Para Yatırma");
                menu.Add(3, "Para Gönderme");
                menu.Add(4, "Bakiye Sorgulama");
            }

            foreach (var item in menu)
            {
                Console.WriteLine("{0}- {1}", item.Key, item.Value);
            }

            byte code = 0;

            Console.WriteLine("İşlem kodu: ");

            while (!byte.TryParse(Console.ReadLine(), out code))
            {
                Console.WriteLine("Hatalı Giriş!\nİşlem kodu: ");
            }
            while (!menu.ContainsKey(code))
            {
                Console.WriteLine("Hatalı Giriş!\nİşlem kodu: ");
                code = byte.Parse(Console.ReadLine());
            }

            return code;
        }
    }
}
