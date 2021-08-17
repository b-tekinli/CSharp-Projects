using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** FIBONACCI *****");


            int a = 0, b = 1, piece, c;


            Console.WriteLine("Kaç tane fibonacci sayısı görmek istediğinizi yazınız: ");
            piece = int.Parse(Console.ReadLine());

            Console.Write(a + " " + b + " ");

            for (int i = 3; i <= piece; i++)
            {
                c = a + b;

                Console.Write(c + " ");

                a = b;
                b = c;
            }
        }
    }
}
