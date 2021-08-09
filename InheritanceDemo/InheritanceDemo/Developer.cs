using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Developer : Employee
    {
        private string languages;
        
        public Developer(int id, string name, string surname, string languages) : base(id, name, surname)
        {
            this.languages = languages;
        }

        public void toFormat(string OS)
        {
            Console.WriteLine(getName() + " şu anda " + OS + " işletim sistemine format atıyor...");
        }
    }
}
