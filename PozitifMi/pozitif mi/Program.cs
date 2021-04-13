using System;

namespace pozitif_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("{0} sayısı pozitiftir.", sayi);
            }
            else if
            {
                Console.WriteLine("{0} sayısı negatiftir.", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı 0'a eşittir.");
            }

            Console.ReadKey();
        }
    }
}
