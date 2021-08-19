using System;
using System.Linq;

namespace ReverseCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** KARAKTER DEĞİŞTİRME *****");

            Console.Write("Yazı Giriniz : ");
            string text = Console.ReadLine();

            char[] arr = text.ToCharArray();

            foreach (var item in arr.Reverse())
            {
                Console.Write(item);
            }
        }
    }
}
