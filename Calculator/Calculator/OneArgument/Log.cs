
using System;

namespace Calculator
{
    public class Log : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Бесконечность");

            }
            if (firstArgument < 0)
            {
                throw new Exception("Не существует");
            }
            return System.Math.Log(firstArgument);
        }
    }
}