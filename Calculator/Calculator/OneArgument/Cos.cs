
namespace Calculator
{
   public class Cos : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculation function Cos(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Cos(x) is calculate
        /// <returns>
        /// return result Cos(x)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Cos(firstArgument);
        }
    }
}
