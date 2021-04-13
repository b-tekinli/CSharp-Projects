using System;

namespace methodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;

            do
            {
                int number;

                do
                {
                    Console.WriteLine("3 haneli bir sayı giriniz: ");
                    number = int.Parse(Console.ReadLine());

                } while (number < 100 || number > 999);
                Console.WriteLine("Tuttuğun sayıyı tersten düşün.");
                Console.ReadLine();
                Console.WriteLine("Büyük olan sayıdan küçük sayıyı çıkar.");
                Console.ReadLine();
                Console.WriteLine("Sonucun son rakamı ne?: ");

                int endNumber = int.Parse(Console.ReadLine());
                switch (endNumber)
                {
                    case 1:
                        Console.WriteLine("İşleminin sonucu 891.");
                        break;
                    case 2:
                        Console.WriteLine("İşleminin sonucu 792.");
                        break;
                    case 3:
                        Console.WriteLine("İşleminin sonucu 693.");
                        break;
                    case 4:
                        Console.WriteLine("İşleminin sonucu 594.");
                        break;
                    case 5:
                        Console.WriteLine("İşleminin sonucu 495.");
                        break;
                    case 6:
                        Console.WriteLine("İşleminin sonucu 396.");
                        break;
                    case 7:
                        Console.WriteLine("İşleminin sonucu 297.");
                        break;
                    case 8:
                        Console.WriteLine("İşleminin sonucu 198.");
                        break;
                    case 9:
                        Console.WriteLine("İşleminin sonucu 099.");
                        break;
                    case 0:
                        Console.WriteLine("İşleminin sonucu 000.");
                        break;

                    default:
                        Console.WriteLine("Son rakamı doğru girdiğinizden emin olun.");
                        break;
                }
                
                Console.WriteLine("Yeniden denemek ister misiniz? Cevabınız evet ise 0'ı tuşlayın.");
                answer = int.Parse(Console.ReadLine());

            } while (answer == 0);

            Console.ReadKey();

        }
    }
}
