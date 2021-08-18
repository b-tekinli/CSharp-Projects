using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Circle : ICalculation
    {
        private double pi = 3.14, r, result, height;

        public double Area()
        {
            Console.WriteLine("Dairenin yarıçapını giriniz: ");
            r = double.Parse(Console.ReadLine());

            result = pi * r * r;

            Console.Write("Dairenin alanı = {0}", result);

            return result;
        }

        public double Circumference()
        {
            Console.WriteLine("Dairenin yarıçapını giriniz: ");
            r = double.Parse(Console.ReadLine());

            result = pi * r * 2;

            Console.Write("Dairenin çevresi = {0}", result);

            return result;
        }

        public double Volume()
        {
            Console.WriteLine("Dairenin yarıçapını giriniz: ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Dairenin yüksekliğini giriniz: ");
            height = double.Parse(Console.ReadLine());
            
            result = 2 * pi * r * r * height;
            
            Console.Write("Dairenin hacmi = {0}", result);
            
            return result;
        }
    }
}
