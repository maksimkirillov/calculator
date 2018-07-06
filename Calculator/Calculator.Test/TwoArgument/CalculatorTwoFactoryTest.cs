using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    public class CalculatorTwoFactoryTest
    {
        [TestCase("addition", typeof(Addition))]
        [TestCase("sabtraction", typeof(Sabtraction))]
        [TestCase("multyplication", typeof(Multyplication))]
        [TestCase("division", typeof(Division))]

        public void CalculattorTest(string name, Type type)
        {
            var calculator = CalculatorTwoFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
