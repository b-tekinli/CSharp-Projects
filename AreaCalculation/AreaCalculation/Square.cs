using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Square : ICalculation
    {
        private double side, height, result;

        public double Area()
        {
            Console.WriteLine("Karenin kenar uzunluğunu giriniz: ");
            side = double.Parse(Console.ReadLine());

            result = side * side;

            Console.Write("Karenin alanı = {0}", result);

            return result;
        }

        public double Circumference()
        {
            Console.WriteLine("Karenin kenar uzunluğunu giriniz: ");
            side = double.Parse(Console.ReadLine());

            result = side * 4;

            Console.Write("Karenin çevresi = {0}", result);

            return result;
        }

        public double Volume()
        {
            Console.WriteLine("Karenin kenar uzunluğunu giriniz: ");
            side = double.Parse(Console.ReadLine());

            Console.WriteLine("Karenin yüksekliğini giriniz: ");
            height = double.Parse(Console.ReadLine());

            result = side * side * height;

            Console.Write("Karenin hacmi = {0}", result);

            return result;
        }
    }
}
