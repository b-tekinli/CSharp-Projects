using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Rectangle : ICalculation
    {
        private double shortSide, longSide, height, length, width, result;

        public double Area()
        {
            Console.WriteLine("Dikdörtgenin kısa kenar uzunluğunu giriniz: ");
            shortSide = double.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin uzun kenar uzunluğunu giriniz: ");
            longSide = double.Parse(Console.ReadLine());

            result = shortSide * longSide;

            Console.Write("Dikdörtgenin alanı = {0}", result);

            return result;
        }

        public double Circumference()
        {
            Console.WriteLine("Dikdörtgenin kısa kenar uzunluğunu giriniz: ");
            shortSide = double.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin uzun kenar uzunluğunu giriniz: ");
            longSide = double.Parse(Console.ReadLine());
            
            result = (shortSide + longSide) * 2;
            
            Console.Write("Dikdörtgenin çevresi = {0}", result);

            return result;
        }

        public double Volume()
        {
            Console.WriteLine("Dikdörtgenin uzunluğunu giriniz: ");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin genişliğini giriniz: ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin yüksekliğini giriniz: ");
            height = double.Parse(Console.ReadLine());

            result = height * length * width;

            Console.Write("Dikdörtgenin hacmi = {0}", result);

            return result;
        }
    }
}
