using System;

namespace Calculator
{
    public class CalculatorOneFactory
    {
        public static ICalculatorOneArgument CreateCalculator(string calculator1Name)
        {
            switch (calculator1Name)
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
