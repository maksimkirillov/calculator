
namespace Calculator.TwoArgument
{
    public class Sabtraction : ICalculateTwoArguments
    {/// <summary>
     /// Calculate function sabtraction
     /// </summary>
     /// <param name="firstArgument"></param>
     /// <param name="secondArgument"></param>
     /// sabtraction is performed
     /// <returns>
     /// Returns  subtraction from the first argument of the second argument
     /// </returns>
        public double Calculator(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
