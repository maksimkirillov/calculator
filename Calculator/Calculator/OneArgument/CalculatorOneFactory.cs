using System;
namespace Calculator.OneArgument
{
    public static class CalculatorOneFactory
    {/// <summary> 
        /// Fabrica for function of one variables 
        /// </summary> 
        /// <param name="calculatorName"> 
        /// the definition of the function on click 
        /// </param> 
        /// <returns> 
        /// Return incstanse of class 
        /// </returns>
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
