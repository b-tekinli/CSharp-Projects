using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        private int id;
        private string name;
        private string surname;

        public Employee(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

        public int getID()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void showInfo()
        {
            Console.WriteLine("\nID: " + this.id);
            Console.WriteLine("İsim: " + this.name);
            Console.WriteLine("Soyisim: " + this.surname);
        }
    }
}
