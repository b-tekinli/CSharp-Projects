using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("***** ÜÇGEN ÇİZME *****\n");

            int length, mid, floor;

            Console.Write("Üçgen uzunluğunu giriniz: ");
            length = Convert.ToInt32(Console.ReadLine());

            mid = length - 1;
            floor = length * 2 - 1;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < floor; j++)
                {
                    if (i + j == mid || j - i == mid)
                    {
                        Console.Write("*");
                    }
                    else if (i + j >= mid && j - i <= mid)
                    {
                        Console.Write("*");
                    }
                    else if (i == mid)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
