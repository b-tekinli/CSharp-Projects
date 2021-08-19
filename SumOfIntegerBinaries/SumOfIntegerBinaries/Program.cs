using System;

namespace SumOfIntegerBinaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Integer İkililerin Toplamı *****");

            int no1, no2, result;

            Console.WriteLine("Bir sayı giriniz: ");
            no1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Bir sayı giriniz: ");
            no2 = int.Parse(Console.ReadLine());

            result = no1 + no2;

            if (no1 != no2)
            {
                Console.WriteLine("Toplamları = {0}", result);
            }
            else
            {
                Console.WriteLine("Toplamlarının karesi = {0}", result * result);
            }
        }
    }
}
