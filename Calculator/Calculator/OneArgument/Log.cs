
namespace Calculator
{
    public class Log : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Log(firstArgument);
        }
    }
}