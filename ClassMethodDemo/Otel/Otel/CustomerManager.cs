using System;
using System.Collections.Generic;
using System.Text;

namespace Otel
{
    class CustomerManager
    {
        public void Add(Customer c)
        {
            Console.WriteLine("Müşteri Ekle\n");
            Console.WriteLine("ID: {0}, Ad: {1}, Soyad: {2}, TC Numarası: {3}, Oda Numarası: {4} bilgilerine sahip müşteri sisteme eklendi.",
                c.ID, c.name, c.surname, c.identityNumber, c.roomNo);
        }

        public void Update(Customer c)
        {
            Console.WriteLine("Müşteri Bilgileri Güncelle\n");
            Console.WriteLine("ID: {0}, Ad: {1}, Soyad: {2}, TC Numarası: {3}, Oda Numarası: {4} bilgilerine sahip müşteri sistemde güncellendi.",
                c.ID, c.name, c.surname, c.identityNumber, c.roomNo);
        }

        public void Show(Customer c)
        {
            Console.WriteLine("Müşteri Bilgileri Görüntüle\n");
            Console.WriteLine("ID: {0}, Ad: {1}, Soyad: {2}, TC Numarası: {3}, Oda Numarası: {4}",
                c.ID, c.name, c.surname, c.identityNumber, c.roomNo);
        }

        public void Show(Customer[] customer)           // overloading
        {
            foreach (var c in customer)
            {
                Console.WriteLine("Müşteri Bilgileri Görüntüle\n");
                Console.WriteLine("ID: {0}\nAd: {1}\nSoyad: {2}\nTC Numarası: {3}\nOda Numarası: {4}",
                    c.ID, c.name, c.surname, c.identityNumber, c.roomNo);
            }
        }

        public void Del(Customer c)
        {
            Console.WriteLine("Müşteri Sil\n");
            Console.WriteLine("ID: {0}, Ad: {1}, Soyad: {2}, TC Numarası: {3}, Oda Numarası: {4} bilgilerine sahip müşteri sistemden silindi.",
                c.ID, c.name, c.surname, c.identityNumber, c.roomNo);
        }
    }
}
