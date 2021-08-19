using System;

namespace ChangeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** KARAKTER DEĞİŞTİRME*****");

            Console.Write("Kelime giriniz: ");
            string word = Console.ReadLine();

            char[] array = word.ToCharArray();

            char temp = array[0];

            char last = array[array.Length - 1];

            array[0] = last;
            array[array.Length - 1] = temp;

            foreach (var item in array)
            {
                Console.Write(item);
            }
        }
    }
}
