using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : ICalculation
    {
        private double side1, side2, side3, height, result;

        public double Area()
        {
            Console.WriteLine("Üçgenin ilk kenar uzunluğunu giriniz: ");
            side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin ikinci kenar uzunluğunu giriniz: ");
            side2 = double.Parse(Console.ReadLine());
            
            result = (side1 * side2) / 2;
            
            Console.Write("Üçgenin alanı = {0}", result);

            return result;
        }

        public double Circumference()
        {
            Console.WriteLine("Üçgenin ilk kenar uzunluğunu giriniz: ");
            side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin ikinci kenar uzunluğunu giriniz: ");
            side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin üçüncü kenar uzunluğunu giriniz: ");
            side3 = double.Parse(Console.ReadLine());

            result = side1 + side2 + side3;
            
            Console.Write("Üçgenin çevresi = {0}", result);

            return result;
        }

        public double Volume()
        {
            Console.WriteLine("Üçgenin dik kenar uzunluğunu giriniz: ");
            side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
            height = double.Parse(Console.ReadLine());
            
            result = (side1 * height);
            
            Console.Write("Üçgenin hacmi = {0}", result);

            return result;
        }
    }
}
