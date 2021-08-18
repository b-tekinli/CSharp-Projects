using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public interface ICalculation
    {
        public double Circumference();
        public double Area();
        public double Volume();
    }
}
