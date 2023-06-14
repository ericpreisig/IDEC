using Calculatrice;

namespace Calculatrice.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_AddsTwoPositiveNumbersCorrectly()
        {
            var result = _calculator.Add(5, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_AddsPositiveAndNegativeNumberCorrectly()
        {
            var result = _calculator.Add(10, -5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_MultipliesTwoPositiveNumbersCorrectly()
        {
            var result = _calculator.Multiply(5, 10);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Multiply_MultipliesPositiveAndNegativeNumberCorrectly()
        {
            var result = _calculator.Multiply(10, -5);
            Assert.AreEqual(-50, result);
        }
    }
}