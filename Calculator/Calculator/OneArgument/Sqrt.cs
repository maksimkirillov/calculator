
namespace Calculator
{
   public class Sqrt : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Sqrt(firstArgument);
        }
    }
}
