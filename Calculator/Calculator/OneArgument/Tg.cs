
namespace Calculator
{
   public class Tg : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Tan(firstArgument);
        }
    }
}
