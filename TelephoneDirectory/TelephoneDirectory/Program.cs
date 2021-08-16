using System;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** REHBER *****");

            TelephoneBook telephoneBook = new TelephoneBook();

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak﻿\n0) Çıkış için\nLütfen işlem seçiniz: ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 0:
                        Console.WriteLine("Çıkış yapıldı.");
                        break;

                    case 1:
                        telephoneBook.SavePerson();
                        break;

                    case 2:
                        telephoneBook.DeletePerson();
                        break;

                    case 3:
                        telephoneBook.UpdatePerson();
                        break;

                    case 4:
                        telephoneBook.ToListPerson();
                        break;

                    case 5:
                        telephoneBook.ToSearchPerson();
                        break;

                    default:
                        Console.WriteLine("Geçersiz karakter girdiniz lütfen tekrar deneyiniz...");
                        break;
                }
            }
        }
    }
}
