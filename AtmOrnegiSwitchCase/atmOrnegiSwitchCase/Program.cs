using System;

namespace atmOrnegiSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM UYGULAMASI");

            int bakiye = 500;

            Console.WriteLine("\n1) Bakiye Görüntüle\n2) Para Çek\n3) Para Yatır\n4) Çıkış Yap");

            Console.WriteLine("Lütfen seçim yapınız: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    break;

                case "2":

                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecekTutar > bakiye)
                    {
                        Console.WriteLine("Bakiyeniz yetersiz. Bakiyenizden fazla para çekemezsiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz: " + (bakiye - cekilecekTutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":

                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                    if (yatirilacakTutar >= bakiye || yatirilacakTutar <= bakiye)
                    {
                        Console.WriteLine("Toplam bakiyeniz: " + (bakiye + yatirilacakTutar) + " TL olarak hesaplanmıştır.");
                        Console.ReadLine();
                    }
                    break;

                case "4":

                    Console.WriteLine("Hesabınızdan çıkış yapıldı. İyi günler...");
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                    break;
            }


        }
    }
}
