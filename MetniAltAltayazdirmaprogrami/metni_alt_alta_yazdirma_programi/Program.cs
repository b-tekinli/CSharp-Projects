using System;

namespace metni_alt_alta_yazdirma_programi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("Bir cümle yazınız: ");
            sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
            Console.ReadKey();
        }
    }
}
