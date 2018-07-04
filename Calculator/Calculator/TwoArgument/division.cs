
using System;

namespace Calculator
{
    public class division: ICalculateTwoArguments
    {
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
