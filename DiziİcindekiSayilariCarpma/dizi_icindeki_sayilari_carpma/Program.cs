using System;

namespace dizi_icindeki_sayilari_carpma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int multiply = 1;
            foreach (int i in numbers)
            {
                multiply *= i;
            }
        }
    }
}
