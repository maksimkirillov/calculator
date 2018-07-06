using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Test.OneArgument
{
    public class CalculatorOneFactoryTest
    {
        [TestCase("Cos", typeof(Calculator.OneArgument.Cos))]
        [TestCase("Sin", typeof(Calculator.OneArgument.Sin))]
        [TestCase("Sqrt", typeof(Calculator.OneArgument.Sqrt))]
        [TestCase("Abs", typeof(Abs))]
        [TestCase("Log", typeof(Calculator.OneArgument.Log))]
        [TestCase("Log10", typeof(Calculator.OneArgument.Log10))]
        [TestCase("Tg", typeof(Calculator.OneArgument.Tg))]
        [TestCase("Square", typeof(Calculator.OneArgument.Square))]
        [TestCase("Cube", typeof(Calculator.OneArgument.Cube))]
        public void CalculattorTest(string name, Type type)
        {
            var calculator = CalculatorOneFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }

}
