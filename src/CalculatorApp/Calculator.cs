using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator : CalculatorBase
    {
        public override int Add(int x ,int y)
        {      
            return x + y;
        }

        public override float Divide(int x ,int y)
        {
            return (float)x / (float)y;
        }

        public override long Multiply(int x ,int y)
        {
           return (long)x * y;
        }

        public override int Substract(int x ,int y)
        {
            return x - y;
        }
    }
}
