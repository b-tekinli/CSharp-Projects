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

                    switch (select)
                    {
                        case 'E':
                            TD.Remove(person);
                            Console.WriteLine("Kişiyi silme işlemi başarılı!");
                            break;
                        case 'H':
                            Console.WriteLine("Kişiyi silmekten vazgeçtiniz.");
                            break;
                    }

                    break;
                }
            }

            if (isAnyone)
            {
                Console.WriteLine("Aradığınız kişi rehberde bulunamadı!");
            }
        }

        public void UpdatePerson()
        {
            Console.WriteLine("Güncellemek istediğiniz kişinin ad ve soyadını giriniz: ");
            string updatePerson = Console.ReadLine();

            Console.WriteLine("Güncel numarayı giriniz: ");
            string newNumber = Console.ReadLine();

            string[] persons = new string[TD.Keys.Count];
            TD.Keys.CopyTo(persons, 0);

            bool isAnyone = false;

            foreach (var person in persons)
            {
                if (persons.Contains(updatePerson))
                {
                    isAnyone = true;

                    Console.WriteLine("\nKişiyi güncellemek istiyor musunuz?(E/H)");
                    char select = char.Parse(Console.ReadLine());

                    switch (select)
                    {
                        case 'E':
                            TD[person] = newNumber;
                            Console.WriteLine("Kişiyi güncelleme işlemi başarılı!");
                            break;
                        case 'H':
                            Console.WriteLine("Kişiyi güncellemekten vazgeçtiniz.");
                            break;
                    }
                    break;
                }
            }

            if (isAnyone)
            {
                Console.WriteLine("Aradığınız kişi rehberde bulunamadı!");
            }
        }

        public void ToListPerson()
        {
            string[] names = new string[TD.Keys.Count];
            TD.Keys.CopyTo(names, 0);

            string[] numbers = new string[TD.Values.Count];
            TD.Values.CopyTo(numbers, 0);

            Console.WriteLine("\n1) A-Z\n2) Z-A\nSıralama türü seçiniz: ");
            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Array.Sort(names);
                    Console.WriteLine("**************************************************");

                    foreach (var name in names)
                    {
                        string[] list = name.Split(' ');
                        Console.WriteLine("Name    : " + list[0]);
                        Console.WriteLine("Surname : " + list[list.Length - 1]);
                        Console.WriteLine("Phone   : " + TD[name]);
                        Console.WriteLine("**********************************************");
                    }
                    break;

                case 2:
                    Array.Sort(names);
                    Array.Reverse(names);
                    Console.WriteLine("**************************************************");

                    foreach (var name in names)
                    {
                        string[] list = name.Split(' ');
                        Console.WriteLine("Name    : " + list[0]);
                        Console.WriteLine("Surname : " + list[list.Length - 1]);
                        Console.WriteLine("Phone   : " + TD[name]);
                        Console.WriteLine("**********************************************");
                    }
                    break;
            }
        }

        public void ToSearchPerson()
        {
            string[] names = new string[TD.Keys.Count];
            TD.Keys.CopyTo(names, 0);

            string[] numbers = new string[TD.Values.Count];
            TD.Values.CopyTo(numbers, 0);

            Console.WriteLine("\n1)İsim veya soyisime göre arama\n2)Telefon numarasına göre arama\nArama türü seçiniz: ");
            int select = int.Parse(Console.ReadLine());

            int counter = 0;

            switch (select)
            {
                case 1:
                    Console.WriteLine("İsim ve soyisim giriniz: ");
                    string keep = Console.ReadLine();

                    Console.WriteLine("****************Arama Sonuçlarınız*****************");
                    foreach (var name in names)
                    {
                        if (name.Contains(keep))
                        {
                            string[] search = name.Split(' ');
                            Console.WriteLine("Name    : " + search[0]);
                            Console.WriteLine("Surname : " + search[search.Length - 1]);
                            Console.WriteLine("Phone   : " + TD[name]);
                            Console.WriteLine("**********************************************");
                        }
                    }

                    if (counter == 0)
                    {
                        Console.WriteLine("Veri bulunamadı!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Telefon numarası giriniz: ");
                    string number = Console.ReadLine();

                    Console.WriteLine("**************************************************");

                    foreach (var no in numbers)
                    {
                        if (no.Contains(number))
                        {
                            counter++;
                            int nameIndex = Array.IndexOf(numbers, number);
                            string name = names[nameIndex];
                            string[] search = name.Split(' ');
                            Console.WriteLine("Name    : " + search[0]);
                            Console.WriteLine("Surname : " + search[search.Length - 1]);
                            Console.WriteLine("Phone   : " + TD[name]);
                            Console.WriteLine("**********************************************");
                        }
                    }

                    if (counter == 0)
                    {
                        Console.WriteLine("Veri bulunamadı!");
                    }
                    break;
            }
        }
    }
}
