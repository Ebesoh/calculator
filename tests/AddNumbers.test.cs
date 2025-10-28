using NUnit.Framework;
using calculator.functions;

namespace calculator.tests
{
    public class AddNumbersTests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            Assert.That(AddNumbers.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            Assert.That(AddNumbers.Add(-2, -3), Is.EqualTo(-4));
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            Assert.That(AddNumbers.Add(3, -2), Is.EqualTo(1));
        }

        [Test]
        public void Add_ZeroAndPositiveNumber_ReturnsPositiveNumber()
        {
            Assert.That(AddNumbers.Add(0, 5), Is.EqualTo(5));
        }

        [Test]
        public void Add_MaxValueAndOne_Overflows()
        {
            Assert.That(AddNumbers.Add(int.MaxValue, 1), Is.EqualTo(int.MinValue));
        }
    }
}