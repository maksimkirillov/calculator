using NUnit.Framework;
using System;

namespace Calculator.Test
{
    public class CalculatorTwoFactoryTest
    {
        [TestCase("addition", typeof(addition))]
        [TestCase("sabtraction", typeof(sabtraction))]
        [TestCase("multyplication", typeof(multyplication))]
        [TestCase("division", typeof(division))]

        public void CalculattorTest(string name, Type type)
        {
            var calculator = CalculatorTwoFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
