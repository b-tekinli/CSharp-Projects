using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public class TelephoneBook
    {
        public string number
        {
            get
            {
                return number.Substring(7, 11) + "****";
            }

            set
            {
                bool control = false;

                if (value.Length == 11)
                {
                    if (control)
                    {
                        Console.WriteLine("Geçersiz karakter girdiniz lütfen tekrar deneyiniz...");
                    }
                    else
                    {
                        number = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz numara 11 karakterli değildir!");
                }
            }
        }

        private Dictionary<string, string> td = new Dictionary<string, string>
        {
            {"Emir Yılmaz", "0500 000 00 00" },
            {"Berat Öz", "0500 000 00 01" },
            {"Yaren Ak", "0500 000 00 02"},
            {"Selin Türk", "0500 000 00 03"},
            {"Şevval Demir", "0500 000 00 04"}
        };

        public Dictionary<string, string> TD { get => td; set => td = value; }

        public void SavePerson()
        {
            Console.WriteLine("İsim giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("İsim giriniz: ");
            string surname = Console.ReadLine();

            string keep = name + " " + surname;

            Console.WriteLine("Numara giriniz: ");
            string number = Console.ReadLine();

            TelephoneBook telephoneBook = new TelephoneBook();
            telephoneBook.number = number;

            td.Add(keep, number);

            Console.WriteLine("Kişi rehbere başarılı bir şekilde kaydedildi!");
        }

        public void DeletePerson()
        {
            Console.WriteLine("Rehberinizden silmek istediğiniz kişinin adını ve soyadını giriniz: ");
            string deletePerson = Console.ReadLine();

            string[] persons = new string[TD.Keys.Count];
            TD.Keys.CopyTo(persons, 0);

            bool isAnyone = false;

            foreach (var person in persons)
            {
                if (person.Contains(deletePerson))
                {
                    isAnyone = true;
                    char select;

                    while (true)
                    {
                        Console.WriteLine("\nKişiyi silmek istiyor musunuz?(E/H)");

                        if (char.TryParse(Console.ReadLine(), out char temp))
                        {
                            select = temp;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz karakter girdiniz lütfen tekrar deneyiniz...");
                        }
                    }
                }
            }
        }
    }
}
