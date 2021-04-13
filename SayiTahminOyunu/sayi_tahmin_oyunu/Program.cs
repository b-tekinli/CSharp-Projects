using System;

namespace sayi_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(0, 100);
            int guess = 0;

            do
            {
                Console.WriteLine("Tuttuğum sayıyı tahmin et: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Aşağı");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Yukarı");
                }
            } while (guess != number);
            Console.WriteLine("Tebrikler");

            Console.ReadKey();
        }
    }
}
