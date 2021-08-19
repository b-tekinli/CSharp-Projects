using System;
using System.Linq;

namespace ReverseCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** KARAKTER TERSTEN YAZDIRMA *****");

            Console.Write("Metin giriniz : ");
            string text = Console.ReadLine();

            char[] arr = text.ToCharArray();

            foreach (var item in arr.Reverse())
            {
                Console.Write(item);
            }
        }
    }
}
