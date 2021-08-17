using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** DAİRE ÇİZME *****");

            Console.WriteLine("Dairenin yarı çapını giriniz: ");
            int r = int.Parse(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if ((i == 1 || i == r) && (j == 1 || j == r))
                    {
                        Console.Write(" ");
                    }
                    else if ((i == 1 || i == r) || (j == 1 || j == r))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }
        }
    }
}
