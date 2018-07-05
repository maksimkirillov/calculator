namespace Calculator
{
   public  class Abs : ICalculatorOneArgument
    {
        /// <summary>
        ///  Calculation function Abs
        /// </summary>
        /// <param name="firstArgument"></param>
        /// calculate is Abs(x)
        /// <returns>
        /// return result Abs(x)
        /// </returns>
        public double Calculator(double firstArgument)
        {
            return System.Math.Abs(firstArgument);
        }
    }
}
