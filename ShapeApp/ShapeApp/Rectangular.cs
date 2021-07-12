using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    public class Rectangular : Shape
    {
        public int shortSide { get; set; }
        public int longSide { get; set; }


        public Rectangular(string name, int shortSide, int longSide) : base(name)
        {
            this.shortSide = shortSide;
            this.longSide = longSide;
        }

        public override void shapeCalculate()
        {
            base.shapeCalculate();
            Console.WriteLine(getName() + "nin alanı: " + (shortSide*longSide));
        }

        public override void shapeShowInfo()
        {
            base.shapeShowInfo();
            Console.WriteLine("Şeklin adı: " + getName());
            Console.WriteLine(getName() + "nin kısa kenarı: " + this.shortSide);
            Console.WriteLine(getName() + "nin uzun kenarı: " + this.longSide);
        }
    }
}
