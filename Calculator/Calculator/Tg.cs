using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
   public class Tg : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Tan(firstArgument);
        }
    }
}
