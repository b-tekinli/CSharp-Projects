using System;

namespace FirstMyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Cümle giriniz: ");
                string sentence = Console.ReadLine().Trim();
                string[] words = sentence.Split(' ');
                string newSentence = "";
                foreach (var item in words)
                {
                    string newWord = prepareWord(item);
                    newSentence += " " + newWord;
                }
                Console.WriteLine(newSentence);

                if (i < 2)
                {
                    Console.WriteLine("Yeni bir cümle girmek ister misiniz? (E/H)");
                    char answer = Convert.ToChar(Console.ReadLine());
                    if (answer == 'h')
                        break;
                }
            }
        }
        private static string prepareWord(string word)
        {
            string newWord = "";
            newWord = word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 2).ToLower() + word.Substring(word.Length - 1).ToUpper();
            return newWord;
        }
    }   

}
