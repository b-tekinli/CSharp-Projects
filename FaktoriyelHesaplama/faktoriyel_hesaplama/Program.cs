using System;

namespace faktoriyel_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;

            while (number > 1)
            {
                faktoriyel *= number;
                number--;
            }

            Console.WriteLine("Faktöriyel = {0}", faktoriyel);

            Console.ReadKey();
        }
    }
}
