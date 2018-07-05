
namespace Calculator
{
   public class Cube : ICalculatorOneArgument
    {
        /// <summary>
        /// Calculation function Cube 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Cube is calculate
        /// <returns>
        /// Returns result Caube
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return firstArgument*firstArgument*firstArgument;
        }
    }
}



