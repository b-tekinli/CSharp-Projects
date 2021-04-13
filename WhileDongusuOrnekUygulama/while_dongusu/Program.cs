using System;

namespace while_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-0 girilene kadar sayı girmeye devam edersiniz.-\nSayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine("Yeni bir sayı giriniz: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("0 girildiği için programdan çıktık.");

            Console.ReadKey();
        }
    }
}
