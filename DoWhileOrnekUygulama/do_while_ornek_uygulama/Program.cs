using System;

namespace do_while_ornek_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                number = new Random().Next(0, 12);
                Console.WriteLine(number);
            } while (number != 5);

            Console.ReadKey();
        }
    }
}
