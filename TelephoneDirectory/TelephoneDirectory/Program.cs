using System;
using System.Collections.Generic;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REHBER\n\n");

            Person person1 = new Person() { name = "Emir", surname = "Yılmaz", number = "0500 000 00 00" };
            Person person2 = new Person() { name = "Berat", surname = "Öz", number = "0500 000 00 01" };
            Person person3 = new Person() { name = "Yaren", surname = "Ak", number = "0500 000 00 02" };
            Person person4 = new Person() { name = "Selin", surname = "Türk", number = "0500 000 00 03" };
            Person person5 = new Person() { name = "Şevval", surname = "Demir", number = "0500 000 00 04" };

            Person[] Persons = new Person[] { person1, person2, person3, person4, person5 };


            while (true)
            {
                Console.WriteLine("(1)Yeni Numara Kaydetmek\n(2)Varolan Numarayı Silmek\n(3)Varolan Numarayı Güncelleme\n(4)Rehberi Listelemek\n(5)Rehberde Arama Yapmak﻿\n(q)Çıkış için\n\nLütfen yapmak istediğiniz işlemi seçiniz: ");
                string choose = Console.ReadLine();


                if (choose == "1")
                {
                    Console.WriteLine("\nLütfen isim giriniz: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("\nLütfen soyisim giriniz: ");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Lütfen telefon numarası giriniz: ");
                    string number = Console.ReadLine();

                    Person p = new Person();
                    p.SaveNumber(person1);
                }
            }
            
        }
    }
}
