using System;

namespace ucgen_ikizkenar_mi_eskenar_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar1, kenar2, kenar3;
            Console.WriteLine("1. kenarı giriniz: ");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kenarı giriniz: ");
            kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. kenarı giriniz: ");
            kenar3 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2 && kenar2 == kenar3)
            {
                Console.WriteLine("Eşkenar üçgen");
            }
            else if (kenar1 == kenar2 || kenar2 == kenar3 || kenar1 == kenar3)
            {
                Console.WriteLine("İkizkenar üçgen");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
            Console.ReadKey();
        }
    }
}
