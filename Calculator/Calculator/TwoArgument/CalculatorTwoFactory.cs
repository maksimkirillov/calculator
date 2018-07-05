using System;

namespace Calculator
{
    public class CalculatorTwoFactory
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
                    return new addition();
                case "sabtraction":
                    return new sabtraction();
                case "multyplication":
                    return new multyplication();
                case "division":
                    return new division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
