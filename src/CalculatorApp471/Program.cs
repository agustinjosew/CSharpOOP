using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp471
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();          

            AdvancedCalculator myAdvancedCalculator = new AdvancedCalculator();          

            CalculatorForm myCalculatorForm = new CalculatorForm();
            
            myCalculatorForm.AddDelegate      = new CalculatorForm.Add(myCalculator.Add);
            myCalculatorForm.SubtractDelegate = new CalculatorForm.Subtract(myCalculator.Substract);
            myCalculatorForm.SquareDelegate   = new CalculatorForm.Square(myAdvancedCalculator.Square);
            myCalculatorForm.SqrtDelegate     = new CalculatorForm.Sqrt(myAdvancedCalculator.SquareRoot);

            myCalculatorForm.DivideDelegate   = new CalculatorForm.Divide(myCalculator.Divide);
            myCalculatorForm.MultiplyDelegate = new CalculatorForm.Multiply(myCalculator.Multiply);

            myCalculatorForm.ShowDialog();
        }
    }
}
