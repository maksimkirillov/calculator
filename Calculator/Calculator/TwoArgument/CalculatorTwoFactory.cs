using System;

namespace Calculator
{
    class CalculatorTwoFactory
    {
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
