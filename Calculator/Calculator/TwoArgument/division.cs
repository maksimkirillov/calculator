
using System;

namespace Calculator
{
    public class division: ICalculateTwoArguments
    {/// <summary>
    /// Calculate function division
    /// </summary>
    /// <param name="firstArgument"></param>
    /// <param name="secondArgument"></param>
    /// Check second argument
    /// if second argument=0
    /// then error
    /// <returns>
    ///Result division of two argument
    /// </returns>
        public double Calculator(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");

            }
            return firstArgument / secondArgument;
        }
    }
}
