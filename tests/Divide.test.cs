using NUnit.Framework;
using calculator.functions;

namespace calculator.tests
{
    public class DivideTests
    {
        [Test]
        public void DivideNumbers_ValidInput_ReturnsQuotient()
        {
            Assert.That(Divide.DivideNumbers(6, 3), Is.EqualTo(2));
        }

        [Test]
        public void DivideNumbers_ZeroDividend_ReturnsZero()
        {
            Assert.That(Divide.DivideNumbers(0, 5), Is.EqualTo(0));
        }

        [Test]
        public void DivideNumbers_NegativeDividend_ReturnsNegativeQuotient()
        {
            Assert.That(Divide.DivideNumbers(-6, 3), Is.EqualTo(-2));
        }

        [Test]
        public void DivideNumbers_NegativeDivisor_ReturnsNegativeQuotient()
        {
            Assert.That(Divide.DivideNumbers(6, -3), Is.EqualTo(-3));
        }

        [Test]
        public void DivideNumbers_BothNegative_ReturnsPositiveQuotient()
        {
            Assert.That(Divide.DivideNumbers(-6, -3), Is.EqualTo(2));
        }
    }
}