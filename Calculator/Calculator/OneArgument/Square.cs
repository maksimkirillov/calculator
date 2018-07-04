
namespace Calculator
{
    public class Square : ICalculatorOneArgument
    {
        public double Calculator(double firstArgument)
        {
            return firstArgument * firstArgument;
        }
    }
}
