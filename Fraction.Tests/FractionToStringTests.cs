using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionToStringTests
    {
        [Test]
        public void OneOverTwo_ToString()
        {
            Assert.That(new Fraction(1, 2).ToString(), Is.EqualTo("1/2"));
        }

        [Test]
        public void Zero_ToString()
        {
            Assert.That(new Fraction(0).ToString(), Is.EqualTo("0"));
        }

        [Test]
        public void ZeroOverOne_ToString()
        {
            Assert.That(new Fraction(0, 1).ToString(), Is.EqualTo("0"));
        }

        [Test]
        public void Two_ToString()
        {
            Assert.That(new Fraction(2).ToString(), Is.EqualTo("2"));
        }

        [Test]
        public void TwoOverOne_ToString()
        {
            Assert.That(new Fraction(2, 1).ToString(), Is.EqualTo("2"));
        }
    }
}