
namespace Calculator
{
    public class Sin : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
       {
          return System.Math.Sin(firstArgument);
       }
    }
}
