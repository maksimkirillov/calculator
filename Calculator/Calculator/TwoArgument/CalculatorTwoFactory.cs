using System;

namespace Calculator.TwoArgument
{
    public static class CalculatorTwoFactory
    {/// <summary> 
        /// Fabrica for function of two variables 
        /// </summary> 
        /// <param name="calculatorName"> 
        /// the definition of the function on click 
        /// </param> 
        /// <returns> 
        /// Return incstanse of class 
        /// </returns>
        public static ICalculateTwoArguments CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "addition":
                    return new Addition();
                case "sabtraction":
                    return new Sabtraction();
                case "multyplication":
                    return new Multyplication();
                case "division":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
