
using System;

namespace Calculator
{
   public class Sqrt : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не существует");
            }
            return System.Math.Sqrt(firstArgument);
        }
    }
}
