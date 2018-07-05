
namespace Calculator
{
    public class Sin : ICalculatorOneArgument
    {/// <summary>
    /// Calculate function Sin(x)
    /// </summary>
    /// <param name="firstArgument"></param>
    /// Sin(x) is calculate
    /// <returns>
    /// Returns result Cos(x)
    /// </returns>
        public double Calculator(double firstArgument)
       {
          return System.Math.Sin(firstArgument);
       }
    }
}
