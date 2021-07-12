using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    public class Triangle : Shape
    {
        public int floorArea { get; set; }
        public int height { get; set; }

        public Triangle(string name, int floorArea, int height) : base(name)
        {
            this.floorArea = floorArea;
            this.height = height;
        }

        public override void shapeCalculate()
        {
            base.shapeCalculate();
            Console.WriteLine(getName() + "nin alanı: " + (floorArea * height) / 2);
        }

        public override void shapeShowInfo()
        {
            base.shapeShowInfo();
            Console.WriteLine("Şeklin adı: " + getName());
            Console.WriteLine(getName() + "nin taban alanı: " + this.floorArea);
            Console.WriteLine(getName() + "nin yüksekliği: " + this.height);
        }
    }
}
