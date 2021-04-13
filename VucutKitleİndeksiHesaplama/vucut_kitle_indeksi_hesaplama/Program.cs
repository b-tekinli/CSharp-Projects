using System;

namespace vucut_kitle_indeksi_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Boyunuzu giriniz-Metre cinsinden-: ");
            double boy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kilonuzu giriniz: ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            double hesapla = kilo / (Math.Pow(boy, 2));

            if (hesapla < 18.49)
            {
                Console.WriteLine("Kilonuz {0} olarak hesaplanmıştır. İdeal kilonun altındasınız.", hesapla);
            }
            else if (hesapla == 18.5 && hesapla <= 24.99)
            {
                Console.WriteLine("Kilonuz {0} olarak hesaplanmıştır. İdeal kilodasınız.", hesapla);
            }
            else if (hesapla == 25 && hesapla <= 29.99)
            {
                Console.WriteLine("Kilonuz {0} olarak hesaplanmıştır. İdeal kilonun üzerindesiniz.", hesapla);
            }
            else if (hesapla >= 30)
            {
                Console.WriteLine("Kilonuz {0} olarak hesaplanmıştır. İdeal kilonun çok üzerindesiniz.", hesapla);
            }
            else
            {
                Console.WriteLine("Invalid.");
            }


            Console.ReadLine();
        }
    }
}
