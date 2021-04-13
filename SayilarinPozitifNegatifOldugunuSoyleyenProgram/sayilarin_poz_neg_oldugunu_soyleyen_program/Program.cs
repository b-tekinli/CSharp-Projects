using System;

namespace sayilarin_poz_neg_oldugunu_soyleyen_program
{
    class Program
    {
        static void Main(string[] args)
        {
            char dene;
            do
            {
                int negativeNumber = 0, positiveNumber = 0, zeroNumber = 0;
                int[] numbers = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}. sayıyı giriniz.", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (var item in numbers)
                {
                    if (item < 0)
                        negativeNumber++;

                    else if (item == 0)
                        zeroNumber++;
                    else
                        positiveNumber++;
                }
                Console.WriteLine("Girilen sayılar, {0} adet negatif, {1} adet sıfır, {2} adet pozitiftir.\nYeniden denemek ister misiniz? (E/H)",
                    negativeNumber, zeroNumber, positiveNumber);
                dene = Convert.ToChar(Console.ReadLine());

            } while (dene == 'e');

            Console.ReadKey();
        }
    }
}
