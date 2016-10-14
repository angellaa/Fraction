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
    }
}
