using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOŞ GELDİNİZ :)");
            

            while (true)
            {
                Console.WriteLine("\n1-Yazılımcı İşlemleri\n2-Yönetici İşlemleri\nq-Çıkış için\nSeçim yapınız: ");
                string choose = Console.ReadLine();

                if (choose == "q")
                {
                    Console.WriteLine("Çıkış yapıldı.");
                    break;
                }
                else if (choose == "1")
                {
                    Developer developer = new Developer(1, "Beyza", "Tekinli", "C#, Python, Java");

                    while (true)
                    {
                        Console.WriteLine("\n1-Format At\n2-Bilgileri Görüntüle\nq-Çıkış için\nYazılımcı işlemi seçiniz:");
                        string devChoose = Console.ReadLine();

                        if (devChoose == "q")
                        {
                            Console.WriteLine("\nYazılımcı işlemlerinden çıkış yapıldı.");
                            break;
                        }
                        else if (devChoose == "1")
                        {
                            Console.WriteLine("\nİşletim sistemi giriniz: ");
                            string OS = Console.ReadLine();

                            developer.toFormat(OS);
                        }
                        else if (devChoose == "2")
                        {
                            developer.showInfo();
                        }
                        else
                        {
                            Console.WriteLine("\nLütfen geçerli bir işlem giriniz...");
                        }
                    }
                }
                else if (choose == "2")
                {
                    Manager manager = new Manager(2, "Şevval", "Tekinli", 12);

                    while (true)
                    {
                        Console.WriteLine("\n1-Zam Yap\n2-Bilgileri Görüntüle\nq-Çıkış için\nYönetici işlemi seçiniz: ");
                        string mngChoose = Console.ReadLine();

                        if (mngChoose == "q")
                        {
                            Console.WriteLine("\nYönetici işlemlerinden çıkış yapıldı.");
                            break;
                        }
                        else if (mngChoose == "1")
                        {
                            Console.Write("\nZam miktarını giriniz: ");
                            int raise = Convert.ToInt32(Console.ReadLine());
                            manager.makeRaise(raise);
                        }
                        else if (mngChoose == "2")
                        {
                            manager.showInfo();
                        }
                        else
                        {
                            Console.WriteLine("\nLütfen geçerli bir işlem giriniz...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nLütfen geçerli bir işlem giriniz...");
                }
            }
        }
    }
}
