using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionEqualityTests
    {
        [Test]
        public void Zero_Equals_FractionZero()
        {
            Assert.That((Fraction)0, Is.EqualTo(new Fraction(0)));
        }

        [Test]
        public void FractionZero_Equals_FractionZero()
        {
            Assert.That(new Fraction(0), Is.EqualTo(new Fraction(0)));
        }

        [Test]
        public void FractionZeroOverOne_Equals_FractionZero()
        {
            Assert.That(new Fraction(0, 1), Is.EqualTo(new Fraction(0)));
        }

        [Test]
        public void Five_Equals_FractionFive()
        {
            Assert.That((Fraction)5, Is.EqualTo(new Fraction(5)));
        }

        [Test]
        public void FractionFive_Equals_FractionFive()
        {
            Assert.That(new Fraction(5), Is.EqualTo(new Fraction(5)));
        }

        [Test]
        public void FractionFiveOverOne_Equals_FractionFive()
        {
            Assert.That(new Fraction(5, 1), Is.EqualTo(new Fraction(5)));
        }

        [Test]
        public void Fraction_EqualsTo_ItSelf()
        {
            var fraction = new Fraction(5, 1);

            Assert.That(fraction, Is.EqualTo(fraction));
        }

        [Test]
        public void Fraction_NotEqualsTo_Null()
        {
            Assert.That(new Fraction(5, 1), Is.Not.EqualTo(null));
        }

        [Test]
        public void Null_NotEqualsTo_Fraction()
        {
            Assert.That(null, Is.Not.EqualTo(new Fraction(5, 1)));
        }
    }
}