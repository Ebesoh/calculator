using NUnit.Framework;
using calculator.functions;

namespace calculator.tests
{
    public class MultiplyTests
    {
        [Test]
        public void MultiplyNumbers_PositiveNumbers_ReturnsCorrectProduct()
        {
            Assert.That(Multiply.MultiplyNumbers(3, 4), Is.EqualTo(12));
        }

        [Test]
        public void MultiplyNumbers_NegativeNumbers_ReturnsCorrectProduct()
        {
            Assert.That(Multiply.MultiplyNumbers(-3, -4), Is.EqualTo(12));
        }

        [Test]
        public void MultiplyNumbers_PositiveAndNegativeNumbers_ReturnsCorrectProduct()
        {
            Assert.That(Multiply.MultiplyNumbers(3, -4), Is.EqualTo(-12));
        }

        [Test]
        public void MultiplyNumbers_ZeroAndPositiveNumber_ReturnsZero()
        {
            Assert.That(Multiply.MultiplyNumbers(0, 5), Is.EqualTo(0));
        }

        [Test]
        public void MultiplyNumbers_LargeNumbers_ReturnsCorrectProduct()
        {
            Assert.That(Multiply.MultiplyNumbers(1000, 1000), Is.EqualTo(1000000));
        }
    }
}