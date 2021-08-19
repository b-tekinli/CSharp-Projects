using System;
using System.Linq;

namespace ConsonantLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** SESSİZ HARF *****");

            Console.Write("Metin giriniz: ");
            string text = Console.ReadLine();

            char[] vowels = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            int number = 0;

            foreach (var item in text)
            {
                if (!vowels.Contains(item))
                {
                    number++;
                }
                else if (number == 2)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    number--;

                    if (number <= 0)
                    {
                        number = 0;
                    }
                }
            }

            if (number < 2)
            {
                Console.WriteLine(false);
            }
        }
    }
}
