
namespace Calculator
{
   public class Log10 : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Log10(firstArgument);
        }
    }
}
