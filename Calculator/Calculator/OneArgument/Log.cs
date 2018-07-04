using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Log : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Log(firstArgument);
        }
    }
}