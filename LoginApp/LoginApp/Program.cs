using System;

namespace LoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLives = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz: ");
                string password = Console.ReadLine();


                if (userName == "ahmet" && password == "12345")
                {
                    Console.WriteLine("Giriş başarılı.");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya parolanız yanlış! Lütfen tekrar deneyiniz...");

                    if (numberOfLives > 0)
                    {
                        numberOfLives -= 1;
                    }
                    if (numberOfLives == 0)
                    {
                        Console.WriteLine("3 başarısız giriş yaptığınız için daha fazla giriş denemesi yapamazsınız.");
                        break;
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
