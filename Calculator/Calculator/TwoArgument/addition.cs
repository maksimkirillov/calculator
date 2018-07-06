
namespace Calculator.TwoArgument
{
    public class Addition : ICalculateTwoArguments
    {/// <summary>
     /// Calculate function addition
     /// </summary>
     /// <param name="firstArgument"></param>
     /// <param name="secondArgument"></param>
     /// <returns>
     /// Returns addition of two arguments
     /// </returns>
        public double Calculator(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
