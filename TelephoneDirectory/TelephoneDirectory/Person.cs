using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string number { get; set; }

        public Person(string name, string surname, string number)
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }


        public Person()
        {
        }

        public void DelNumber(Person person)
        {
            Console.WriteLine("{0} {1} adlı kişi rehberden silindi.", person.name, person.surname);
        }

        public void ListDirectory(Person person)
        {
            //foreach (Person persons in Persons)
            //{
            //    Console.WriteLine(person.name);
            //}

            Console.WriteLine("Kişileriniz listelendi.");
        }

        public void SaveNumber(Person person)
        {
            Console.WriteLine("{0} {1} adlı kişi {2} numarasıyla rehbere kaydedildi.", person.name, person.surname, person.number);
        }

        public void SearchDirectory(Person person)
        {
            //if (Persons.Contains(person))
            //{
                
            //}

            Console.WriteLine("{0} adlı kişi bu rehberde mevcuttur.", person.name);
        }

        public void UpdateNumber(Person person)
        {
            Console.WriteLine("{0} {1} adlı kişi güncellendi.", person.name, person.surname);
        }
    }
}
