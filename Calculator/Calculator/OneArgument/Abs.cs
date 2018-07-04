namespace Calculator
{
   public  class Abs : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return System.Math.Abs(firstArgument);
        }
    }
}
