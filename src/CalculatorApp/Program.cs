using System;

namespace CalculatorApp
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

            int resultOne     = myCalculator.Add(x,y);
            int resultTwo     = myCalculator.Substract(x,y);
            float resultThree = myCalculator.Divide(x,y);
            Int64 resultFour  = myCalculator.Multiply(x,y);
        }
    }
}
