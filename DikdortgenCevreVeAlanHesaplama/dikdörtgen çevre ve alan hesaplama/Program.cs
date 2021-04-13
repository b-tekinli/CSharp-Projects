using System;

namespace dikdortgen_cevre_alan_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DİKDÖRTGEN ÇEVRE VE ALAN HESAPLAMA UYGULAMASI");


            Console.WriteLine("Uzun kenar: ");
            int uzunKenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kısa kenar: ");
            int kisaKenar = Convert.ToInt32(Console.ReadLine());
            int cevre = 2 * (kisaKenar + uzunKenar);
            int alan = kisaKenar * uzunKenar;

            Console.WriteLine("Dikdörtgenin çevresi = {0}, alanı = {1}", cevre, alan);
            Console.ReadKey();
        }
    }
}
