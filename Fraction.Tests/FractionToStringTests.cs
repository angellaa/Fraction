using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionToStringTests
    {
        [Test]
        public void Fraction()
        {
            Assert.That(new Fraction(1, 2).ToString(), Is.EqualTo("1/2"));
        }

        [Test]
        public void ZeroFraction()
        {
            Assert.That(new Fraction(0).ToString(), Is.EqualTo("0"));
        }

        [Test]
        public void IntegerFraction()
        {
            Assert.That(new Fraction(2).ToString(), Is.EqualTo("2"));
        }

        [Test]
        public void NegativeIntegerFraction()
        {
            Assert.That(new Fraction(-10).ToString(), Is.EqualTo("-10"));
        }

        [Test]
        public void NegativeFraction()
        {
            Assert.That(new Fraction(-3, 8).ToString(), Is.EqualTo("-3/8"));
        }
    }
}