using System;

namespace GirilenSayininKaresiniAlmaMetotOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int kareDeger = kareAl(sayi);

            if (kareDeger > 25)
            {
                Console.WriteLine("Girdiğiniz sayının karesi 25'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayının karesi 25'ten küçüktür.");
            }

            Console.ReadLine();
        }

        static int kareAl(int a)
        {
            return a * a;
        }
    }
}
