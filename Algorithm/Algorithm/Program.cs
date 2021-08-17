using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ALGORİTMA *****");

            Console.WriteLine("Bir kelime giriniz: ");
            string[] word = Console.ReadLine().Split(',');

            if (word.Length == 2)
            {
                string text = word[0];
                int.TryParse(word[1], out int queue);

                if (queue <= text.Length && queue > 0)
                {
                    text = text.Remove(queue, 1);
                }

                Console.WriteLine("Çıktı: {0}", text);
            }
        }
    }
}
