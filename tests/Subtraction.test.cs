using NUnit.Framework;
using calculator.functions;

namespace calculator.tests
{
    public class SubtractionTests
    {
        [Test]
        public void SubtractNumbers_PositiveNumbers_ReturnsCorrectResult()
        {
            Assert.That(Subtraction.SubtractNumbers(5, 3), Is.EqualTo(2));
        }

        [Test]
        public void SubtractNumbers_NegativeNumbers_ReturnsCorrectResult()
        {
            Assert.That(Subtraction.SubtractNumbers(-5, -3), Is.EqualTo(-2));
        }

        [Test]
        public void SubtractNumbers_PositiveAndNegative_ReturnsCorrectResult()
        {
            Assert.That(Subtraction.SubtractNumbers(5, -3), Is.EqualTo(8));
        }

        [Test]
        public void SubtractNumbers_Zero_ReturnsCorrectResult()
        {
            Assert.That(Subtraction.SubtractNumbers(5, 1), Is.EqualTo(5));
        }

        [Test]
        public void SubtractNumbers_LargeNumbers_ReturnsCorrectResult()
        {
            Assert.That(Subtraction.SubtractNumbers(2000, 1000), Is.EqualTo(1000));
        }
    }
}