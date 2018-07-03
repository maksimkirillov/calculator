using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class CalculatorOneFactory
    {
        public static ICalculatorOneArgument CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new Sin();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
