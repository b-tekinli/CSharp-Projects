using System;

namespace basit_hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int carp = sayi1 * sayi2;
            int bol = sayi1 / sayi2;

            Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);

            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, fark);

            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, carp);

            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, bol);


            // mod almak için

            int mod = sayi1 % sayi2;
            Console.WriteLine(mod);

            Console.ReadKey();
        }
    }
}
