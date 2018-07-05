
using System;

namespace Calculator
{
    public class Log : ICalculatorOneArgument
    {/// <summary>
     /// Calculation function Log
     /// </summary>
     /// <param name="firstArgument"></param>
     /// Log is calculate
     /// Check for erroneous situations
     /// <returns>
     /// Return result Log
     /// </returns>
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