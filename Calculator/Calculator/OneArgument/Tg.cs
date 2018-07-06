
namespace Calculator.OneArgument
{
   public class Tg : ICalculatorOneArgument
    {/// <summary>
     /// Calculate function Tg(x)
     /// </summary>
     /// <param name="firstArgument"></param>
     /// Tg(x) is calculate
     /// <returns>
     /// Returns result Tg(X)
     /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Tan(firstArgument);
        }
    }
}
