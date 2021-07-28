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
            int x = 23;
            int y = 2;

            //1. Create abstract CalculatorBase class with Add, Substract, Multiply and Divide functionality
            //2. create derived SimpleCalculator class of the base class you just created and make the calculations with given X and Y values
            //3. Create IAdvancedCalculator interface with SquareRoot, Square, Cube functionalities
            //4. Create derived AdvancedCalculator class of CalculatorBase and IAdvancedCalculator structures

            Calculator myCalculator = new Calculator();

            //int   resultOne   = myCalculator.Add(x,y);
            //int   resultTwo   = myCalculator.Substract(x,y);
            //float resultThree = myCalculator.Divide(x,y);
            //Int64 resultFour  = myCalculator.Multiply(x,y);

            AdvancedCalculator myAdvancedCalculator = new AdvancedCalculator();

            //resultOne = myCalculator.Add(x ,y);
            //resultTwo = myCalculator.Substract(x ,y);
            //resultThree = myCalculator.Divide(x ,y);
            //resultFour = myCalculator.Multiply(x ,y);

            //long   resultFive  = myAdvancedCalculator.Cube(x);
            //long   resultSix   = myAdvancedCalculator.Square(x);
            //double resultSeven = myAdvancedCalculator.SquareRoot(x);

            CalculatorForm myCalculatorForm = new CalculatorForm();

            myCalculatorForm.AddDelegate      = new CalculatorForm.Add(myCalculator.Add);
            myCalculatorForm.SubtractDelegate = new CalculatorForm.Subtract(myCalculator.Substract);
            myCalculatorForm.SquareDelegate   = new CalculatorForm.Square(myAdvancedCalculator.Square);
            myCalculatorForm.SqrtDelegate     = new CalculatorForm.Sqrt(myAdvancedCalculator.SquareRoot);

            myCalculatorForm.ShowDialog();
        }
    }
}
