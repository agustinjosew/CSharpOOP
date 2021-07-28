using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp471
{
    public interface IAdvancedCalculator
    {
        double SquareRoot(int x);
        long   Square(int x);
        long   Cube(int x);
    }
}
