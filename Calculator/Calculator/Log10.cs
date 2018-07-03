using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Log10 : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Log10(firstArgument);
        }
    }
}
