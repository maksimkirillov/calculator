using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
   public class Cos : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Cos(firstArgument);
        }
    }
}
