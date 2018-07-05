
namespace Calculator
{
    public class multyplication: ICalculateTwoArguments
    {/// <summary>
     /// Calculate function multyplication
     /// </summary>
     /// <param name="firstArgument"></param>
     /// <param name="secondArgument"></param>
     /// Multiplication is performed
     /// <returns>
     /// Returns   multyplication of two argument
     /// </returns>
        public double Calculator(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
