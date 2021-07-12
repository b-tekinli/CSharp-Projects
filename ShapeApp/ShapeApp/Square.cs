using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    public class Square : Shape
    {
        public int side { get; set; }

        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }

        public override void shapeCalculate()
        {
            base.shapeCalculate();
            Console.WriteLine(getName() + "nin alanı: " + (side * side));
        }

        public override void shapeShowInfo()
        {
            base.shapeShowInfo();
            Console.WriteLine("Şeklin adı: " + getName());
            Console.WriteLine(getName() + "nin kenarı: " + this.side);
        }
    }
}
