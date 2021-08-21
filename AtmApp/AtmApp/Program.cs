using System;
using System.Collections.Generic;
using System.Linq;
using static AtmApp.Enums;

namespace AtmApp
{
    class Program
    {
        public static List<Person> persons = new();

        static void Main(string[] args)
        {
            Console.WriteLine("***** ATM APP *****");

            persons = DataGenerator.Persons;

            bool flag = true;


        APoint:
            Console.WriteLine("*** A BANK ***");

            Console.WriteLine("TC kimlik numaranızı giriniz: ");
            string tc = Console.ReadLine().Trim();

            Person person = persons.FirstOrDefault(x => x.identityNo == tc);

            if (person is null)
            {
                Console.WriteLine("Geçersiz giriş!");
                flag = false;
            }

            Console.WriteLine("4 haneli şifrenizi giriniz: ");
            string pass = Console.ReadLine().Trim();

            if (person.pass != pass)
            {
                Console.WriteLine("Geçersiz giriş!");
                goto APoint;
            }


        BPoint:
            Console.WriteLine("*** B BANK ***");

            byte code = Menu.OperationMenu();

            if (code == 1)
            {
                float amount = 0f;

                Console.WriteLine("Kaç miktar para çekmek istediğinizi giriniz: ");
                float.TryParse(Console.ReadLine(), out amount);

                if (amount > 0 && amount <= person.balance)
                {
                    person.balance -= amount;
                    Console.WriteLine("Kartınızı almayı unutmayınız!");
                }
                else
                {
                    Logger.CreateFile(LogTypes.Fraud, person, null, "Geçersiz giriş!");
                    goto BPoint;
                }
            }

            if (code == 2)
            {
                Console.WriteLine($"Mevcut bakiyeniz: {person.balance}");
                goto BPoint;
            }

            if (code == 3)
            {
                Console.WriteLine("Kaç miktar para yatırmak istediğinizi giriniz: ");
                float amount = 0f;
                float.TryParse(Console.ReadLine(), out amount);

                if (amount > 0)
                {
                    person.balance += amount;
                    Console.WriteLine("Lütfen bekleyiniz...\nPara yatırma işleminiz başarılı bir şekilde gerçekleşmiştir.");

                    Logger.CreateFile(LogTypes.Deposit, person, null, $"Miktar: {amount} - İşlem başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    Logger.CreateFile(LogTypes.Fraud, person, null, "Geçersiz giriş!");
                }
            }

            if (code == 4)
            {
                var to = AtmOperations.SendMoney();

                if (to is null)
                {
                    Console.WriteLine("Geçersiz giriş!");
                    goto BPoint;
                }
                else
                {
                    Console.WriteLine("Göndereceğiniz miktarı giriniz: ");
                    float.TryParse(Console.ReadLine(), out float amount);

                    if (amount > 0)
                    {
                        if (AtmOperations.SendMoney(person, to, amount) == Operations.successfull)
                        {
                            Console.WriteLine("Para başarılı bir şekilde gönderilmiştir.");
                            goto BPoint;
                        }
                        else
                        {
                            Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır!");
                            goto BPoint;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş! Kartınızı almayı unutmayınız!");
                    }
                }
            }
        }
    }
}
