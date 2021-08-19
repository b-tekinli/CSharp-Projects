using System;
using System.Collections.Generic;

namespace Absolutesquaring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** MUTLAK KARE ALMA *****");

            int numbers, no;

            Console.WriteLine("Kaç sayı girmek istediğinizi yazınız: ");
            numbers = int.Parse(Console.ReadLine());

            List<int> smallNumbers = new();
            List<int> bigNumbers = new();

            for (int i = 0; i < numbers; i++)
            {
                Console.Write("Sayı giriniz: ");
                no = int.Parse(Console.ReadLine());

                if (no > 67)
                {
                    bigNumbers.Add(no);
                }
                else if (no < 67)
                {
                    smallNumbers.Add(no);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş!");
                }
            }

            CalcBig(bigNumbers);
            CalcSmall(smallNumbers);
        }

        public static void CalcBig(List<int> list)
        {
            int result = 0;

            foreach (var item in list)
            {
                result = result + (int)Math.Pow(item - 67, 2);
            }
            Console.WriteLine("\n67'den büyük olan sayıların farklarının karesi = {0}", result);
        }

        public static void CalcSmall(List<int> list)
        {
            int result = 0;

            foreach (var item in list)
            {
                result = result + (67 - item);
            }
            Console.WriteLine("67'den küçük olan sayıların farklarının toplamı = {0}", result);
        }
    }
}
