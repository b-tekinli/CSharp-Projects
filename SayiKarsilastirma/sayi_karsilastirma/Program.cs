using System;

namespace sayi_karsilastirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("1. sayıyı giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((b < a && a < c) || (c < a && a < b))
            {
                Console.WriteLine("Ortanca sayı {0}", a);
            }
            else if ((a < b && b < c) || (c < b && b < a))
            {
                Console.WriteLine("Ortanca sayı {0}", b);
            }
            else if ((a < c && c < b) || (b < c && c < a))
            {
                Console.WriteLine("Ortanca sayı {0}", c);
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
            Console.ReadKey();
        }
    }
}
