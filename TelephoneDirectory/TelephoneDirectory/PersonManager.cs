using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public class PersonManager : IPerson
    {
        public void DelNumber(Person person)
        {
            Console.WriteLine("{0} {1} adlı kişi rehberden silindi.", person.name, person.surname);
        }

        public void ListDirectory(Person person)
        {
            throw new NotImplementedException();
        }

        public void SaveNumber(Person person)
        {
            Console.WriteLine("{0} {1} adlı kişi rehbere kaydedildi.", person.name, person.surname);
        }

        public void SearchDirectory(Person person)
        {
            throw new NotImplementedException();
        }

        public void UpdateNumber(Person person)
        {
            Console.WriteLine("{0} {1} adlı kişi güncellendi.", person.name, person.surname);
        }
    }
}
