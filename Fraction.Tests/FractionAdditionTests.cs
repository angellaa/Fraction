using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionAdditionTests
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
        public void IntegerFraction_Plus_IntegerFraction()
        {
            Assert.That(new Fraction(4) + new Fraction(9), Is.EqualTo(new Fraction(13)));
        }

        [Test]
        public void Integer_Plus_IntegerFraction()
        {
            Assert.That(4 + new Fraction(9), Is.EqualTo(new Fraction(13)));
        }

        [Test]
        public void IntegerFraction_Plus_Integer()
        {
            Assert.That(new Fraction(4) + 9, Is.EqualTo(new Fraction(13)));
        }

        [Test]
        public void Zero_Plus_Fraction()
        {
            Assert.That(0 + new Fraction(1, 2), Is.EqualTo(new Fraction(1, 2)));
        }

        [Test]
        public void Integer_Plus_Fraction()
        {
            Assert.That(5 + new Fraction(1, 2), Is.EqualTo(new Fraction(11, 2)));
        }

        [Test]
        public void Fraction_Plus_Integer()
        {
            Assert.That(new Fraction(1, 2) + 7, Is.EqualTo(new Fraction(15, 2)));
        }

        [Test]
        public void SameDenominators()
        {
            Assert.That(new Fraction(1, 3) + new Fraction(4, 3), Is.EqualTo(new Fraction(5, 3)));
        }

        [Test]
        public void Fraction_Plus_Fraction_NoReduceRequired()
        {
            Assert.That(new Fraction(7, 3) + new Fraction(4, 5), Is.EqualTo(new Fraction(47, 15)));
        }

        [Test]
        public void DenominatorMultipleOfTheOther()
        {
            Assert.That(new Fraction(1, 3) + new Fraction(5, 6), Is.EqualTo(new Fraction(7, 6)));
        }

        [Test]
        public void Fraction_Plus_Fraction_ReduceRequired()
        {
            Assert.That(new Fraction(1, 2) + new Fraction(1, 6), Is.EqualTo(new Fraction(2, 3)));
        }

        [Test]
        public void NegativeFraction_Plus_Fraction()
        {
            Assert.That(new Fraction(-1, 2) + new Fraction(1, 3), Is.EqualTo(new Fraction(-1, 6)));
        }
    }
}