using NUnit.Framework;

namespace DotnetBambooSpecs.SampleProject.UnitTests
{
    [TestFixture]
    public class CalculatorFixture

    {
        [TestCase(1, ExpectedResult = 2)]
        [TestCase(2, ExpectedResult = 3)]
        [TestCase(3, ExpectedResult = 4)]
        [TestCase(4, ExpectedResult = 5)]
        [TestCase(5, ExpectedResult = 6)]
        [TestCase(6, ExpectedResult = 7)]
        [TestCase(7, ExpectedResult = 8)]
        [TestCase(8, ExpectedResult = 9)]
        [TestCase(9, ExpectedResult = 10)]
        [TestCase(10, ExpectedResult = 11)]
        public int Increment(int a)
        {
            return Calculator.Increment(a);
        }

        [TestCase(1, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        [TestCase(4, ExpectedResult = 3)]
        [TestCase(5, ExpectedResult = 4)]
        [TestCase(6, ExpectedResult = 5)]
        [TestCase(7, ExpectedResult = 6)]
        [TestCase(8, ExpectedResult = 7)]
        [TestCase(9, ExpectedResult = 8)]
        [TestCase(10, ExpectedResult = 9)]
        public int Decrement(int a)
        {
            return Calculator.Decrement(a);
        }

        [TestCase(1, 0, ExpectedResult = 0)]
        [TestCase(2, 1, ExpectedResult = 2)]
        [TestCase(3, 2, ExpectedResult = 6)]
        [TestCase(4, 3, ExpectedResult = 12)]
        [TestCase(5, 4, ExpectedResult = 20)]
        [TestCase(6, 5, ExpectedResult = 30)]
        [TestCase(7, 6, ExpectedResult = 42)]
        [TestCase(8, 7, ExpectedResult = 56)]
        [TestCase(9, 8, ExpectedResult = 72)]
        [TestCase(10, 9, ExpectedResult = 90)]
        public int Multiply(int a, int b)
        {
            return Calculator.Multiply(a, b);
        }
    }
}
