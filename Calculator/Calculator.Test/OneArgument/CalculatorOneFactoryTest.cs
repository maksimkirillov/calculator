using NUnit.Framework;
using System;

namespace Calculator.Test
{
    public class CalculatorOneFactoryTest
    {
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Sqrt", typeof(Sqrt))]
        [TestCase("Abs", typeof(Abs))]
        [TestCase("Log", typeof(Log))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("Tg", typeof(Tg))]
        [TestCase("Square", typeof(Square))]
        [TestCase("Cube", typeof(Cube))]
        public void CalculattorTest(string name, Type type)
        {
            var calculator = CalculatorOneFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }

}
