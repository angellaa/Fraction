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
        public void DenominatorIsImplicitelyOne()
        {
            Assert.That(new Fraction(5, 1), Is.EqualTo(new Fraction(5)));
        }

        [Test]
        public void Integer_Equals_IntegerFraction()
        {
            Assert.That((Fraction)5, Is.EqualTo(new Fraction(5)));
        }

        [Test]
        public void IntegerFraction_Equals_IntegerFraction()
        {
            Assert.That(new Fraction(5), Is.EqualTo(new Fraction(5)));
        }

        [Test]
        public void Fraction_Equals_Fraction()
        {
            Assert.That(new Fraction(3, 4), Is.EqualTo(new Fraction(3, 4)));
        }

        [Test]
        public void Fraction_EqualsTo_ItSelf()
        {
            var fraction = new Fraction(5, 3);

            Assert.That(fraction, Is.EqualTo(fraction));
        }

        [Test]
        public void Fraction_NotEqualsTo_Null()
        {
            Assert.That(new Fraction(9, 4), Is.Not.EqualTo(null));
        }

        [Test]
        public void Null_NotEqualsTo_Fraction()
        {
            Assert.That(null, Is.Not.EqualTo(new Fraction(2, 7)));
        }

        [Test]
        public void FractionWithNegativeDenominator_Equals_FractionWithNegativeNumerator()
        {
            Assert.That(new Fraction(1, -2), Is.EqualTo(new Fraction(-1, 2)));
        }

        [Test]
        public void NegativeNumeratorAndDenominator_Equals_PositiveNumeratorAndDenominator()
        {
            Assert.That(new Fraction(-3, -4), Is.EqualTo(new Fraction(3, 4)));
        }

        [Test]
        public void DifferentNumerators()
        {
            Assert.That(new Fraction(1, 3), Is.Not.EqualTo(new Fraction(2, 3)));
        }

        [Test]
        public void DifferentDenominators()
        {
            Assert.That(new Fraction(1, 3), Is.Not.EqualTo(new Fraction(1, 4)));
        }

        [Test]
        public void Fraction_Equals_ReducedFraction()
        {
            Assert.That(new Fraction(2, 3), Is.EqualTo(new Fraction(4, 6)));
        }
    }
}