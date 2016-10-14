using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionTests
    {
        [Test]
        public void FractionZero_Plus_FractionZero()
        {
            Assert.That(new Fraction(0) + new Fraction(0), Is.EqualTo(new Fraction(0)));
        }

        [Test]
        public void Zero_Plus_FractionZero()
        {
            Assert.That(0 + new Fraction(0), Is.EqualTo(new Fraction(0)));
        }

        [Test]
        public void FractionZero_Plus_Zero()
        {
            Assert.That(new Fraction(0) + 0, Is.EqualTo(new Fraction(0)));
        }

        [Test]
        public void FractionFour_Plus_FractionNine()
        {
            Assert.That(new Fraction(4) + new Fraction(9), Is.EqualTo(new Fraction(13)));
        }

        [Test]
        public void Four_Plus_FractionNine()
        {
            Assert.That(4 + new Fraction(9), Is.EqualTo(new Fraction(13)));
        }

        [Test]
        public void FractionFour_Plus_Nine()
        {
            Assert.That(new Fraction(4) + 9, Is.EqualTo(new Fraction(13)));
        }
    }
}
