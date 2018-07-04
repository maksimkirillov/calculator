
namespace Calculator
{
   public class Cos : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Cos(firstArgument);
        }
    }
}
