using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class AdvancedCalculator : Calculator, IAdvancedCalculator
    {
        public long Cube(int x)
        {
            return ( long ) x * x * x;            
        }

        public long Square(int x)
        {
            return ( long ) x * x;
        }

        public double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
