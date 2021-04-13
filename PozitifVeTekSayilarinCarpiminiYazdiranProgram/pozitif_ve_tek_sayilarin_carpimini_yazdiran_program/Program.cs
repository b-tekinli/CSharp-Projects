using System;

namespace pozitif_ve_tek_sayilarin_carpimini_yazdiran_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen 5 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran

            int number;
            int counter = 1;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Sayı giriniz: ");                // Console.WriteLine("{0}. sayıyı giriniz: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                if ((number > 0) && (number % 2 == 1))
                {
                    counter *= number;                              // counter += number; yapmış olsaydım 
                }
            }
            Console.WriteLine("Pozitif ve tek olan sayıların çarpımı: " + counter);


            Console.ReadKey();
        }
    }
}
