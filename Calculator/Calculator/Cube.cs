using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Cube : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return firstArgument*firstArgument*firstArgument;
        }
    }
}



