using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Manager : Employee
    {
        private int personsResponsible;

        public Manager(int id, string name, string surname, int personsResponsible) : base(id, name, surname)
        {
            this.personsResponsible = personsResponsible;
        }

        public void makeRaise(int raise)
        {
            Console.WriteLine(getName() + " " + raise + " TL çalışanlara zam yapıyor...");
        }
    }
}
