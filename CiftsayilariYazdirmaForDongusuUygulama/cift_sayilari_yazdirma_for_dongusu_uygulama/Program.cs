using System;

namespace for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2;

            Console.WriteLine("1. sayıyı giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 < number2)
            {
                for (int sayac = number1; sayac < number2; sayac++)
                {
                    if (sayac % 2 == 0)
                    {
                        Console.WriteLine(sayac);
                    }

                }

            }
            else if (number1 > number2)
            {
                for (int sayac = number1; sayac > number2; sayac--)
                {
                    if (sayac % 2 == 0)
                    {
                        Console.WriteLine(sayac);
                    }
                }
            }
            else
            {
                Console.WriteLine("1. ve 2. sayı eşittir.");
            }

            Console.ReadKey();
        }
    }
}
