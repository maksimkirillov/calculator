
namespace Calculator.OneArgument
{
    public class Square : ICalculatorOneArgument
    {/// <summary>
     /// Calculate function Square(x)
     /// </summary>
     /// <param name="firstArgument"></param>
     /// Square(x) is calculate
     /// <returns>
     /// Returns result Square(X)
     /// </returns>
        public double Calculator(double firstArgument)
        {
            return firstArgument * firstArgument;
        }
    }
}
