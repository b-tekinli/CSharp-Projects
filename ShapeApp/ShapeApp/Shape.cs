using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    public class Shape
    {
        public string name { get; set; }

        public Shape(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public virtual void shapeCalculate()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor...");
        }

        public virtual void shapeShowInfo()
        {
            Console.WriteLine(getName() + "nin bilgileri!");
        }
    }
}
