using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
   public class Sqrt : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Sqrt(firstArgument);
        }
    }
}
