using System;

namespace girilen_sayinin_kac_basamakli_oldugunu_soyleyen_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int step = 0;

            while (number > 0)
            {
                step++;
                number /= 10;
            }
            Console.WriteLine("Girdiğiniz sayı: " + step.ToString() + "basamaklıdır.");

        }
    }
}
