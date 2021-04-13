using System;

namespace kare_cizen_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            
            do
            {
                Console.WriteLine("Karenin 1 kenar uzunluğu: ");
                int kenar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < kenar; i++)
                {
                    string kare = " ";
                    for (int a = 0; a < kenar; a++)
                    {
                        kare += "*";
                    }
                    Console.WriteLine(kare);
                }
                Console.WriteLine("-E/H-\nYeniden denemek ister misiniz: ");
                answer = Convert.ToString(Console.ReadLine());

            } while (answer == "E");
            
        }
    }
}
