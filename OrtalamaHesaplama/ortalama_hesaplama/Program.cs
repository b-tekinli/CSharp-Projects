using System;

namespace ortalama_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ORTALAMA HESAPLAMA");


            Console.WriteLine("Vize notunuz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunuz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            double basariNotu = (vize * 0.4) + (final * 0.6);

            if (basariNotu >= 60)
            {
                Console.WriteLine("Tebrikler geçtiniz :)");
            }
            else if (basariNotu >= 50)
            {
                Console.WriteLine("Şartlı geçtiniz. Daha çok çalışmalısınz...");
            }
            else
            {
                Console.WriteLine("Maalesef kaldınız :(");
            }

            Console.ReadKey();
        }
    }
}
