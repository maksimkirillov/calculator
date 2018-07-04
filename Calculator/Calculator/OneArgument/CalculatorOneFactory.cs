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
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                case "Sqrt":
                    return new Sqrt();
                case "Log10":
                    return new Log10();
                case "Log":
                    return new Log();
                case "Cube":
                    return new Cube();
                case "Square":
                    return new Square();
                case "Abs":
                    return new Abs();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
