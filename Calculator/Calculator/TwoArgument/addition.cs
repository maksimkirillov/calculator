
namespace Calculator
{
    public class addition : ICalculateTwoArguments
    {
        public double Calculator(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
