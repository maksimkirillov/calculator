
using System;

namespace Calculator.OneArgument
{
   public class Log10 : ICalculatorOneArgument
    {/// <summary>
        /// Calculation function Log10
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Log10 is calculate
        /// Check for erroneous situations
        /// <returns>
        /// Return result Log10
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
            return System.Math.Log10(firstArgument);
        }
    }
}
