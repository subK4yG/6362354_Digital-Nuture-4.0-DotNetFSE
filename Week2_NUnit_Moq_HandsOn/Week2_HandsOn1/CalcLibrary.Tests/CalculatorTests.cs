using NUnit.Framework;
using CalcLibrary;
namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;
        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }
        [TearDown]
        public void TearDown()
        {
            _calc = null;
        }
        [Test]
        public void Add_AddsTwoPositiveNumbers_ReturnsCorrectSum()
        {
            var result = _calc.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }
        [TestCase(10, 20, 30)]
        [TestCase(-5, -5, -10)]
        [TestCase(0, 0, 0)]
        public void Add_UsingTestCaseAttribute_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        [Ignore("Skipping this test for now.")]
        public void ThisTestWillBeIgnored()
        {
            Assert.Fail("This should be ignored.");
        }
    }
}
