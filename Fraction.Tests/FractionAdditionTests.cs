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

        [Test]
        public void Zero_Plus_OneOverTwo()
        {
            Assert.That(0 + new Fraction(1, 2), Is.EqualTo(new Fraction(1, 2)));
        }

        [Test]
        public void One_Plus_OneOverTwo()
        {
            Assert.That(1 + new Fraction(1, 2), Is.EqualTo(new Fraction(3, 2)));
        }

        [Test]
        public void Five_Plus_OneOverTwo()
        {
            Assert.That(5 + new Fraction(1, 2), Is.EqualTo(new Fraction(11, 2)));
        }

        [Test]
        public void OverOverTwo_Plus_Five()
        {
            Assert.That(new Fraction(1, 2) + 5, Is.EqualTo(new Fraction(11, 2)));
        }

        [Test]
        public void OneOverThree_Plus_FourOverThree()
        {
            Assert.That(new Fraction(1, 3) + new Fraction(4, 3), Is.EqualTo(new Fraction(5, 3)));
        }

        [Test]
        public void SevenOveThree_Plus_FourOverFive()
        {
            Assert.That(new Fraction(7, 3) + new Fraction(4, 5), Is.EqualTo(new Fraction(47, 15)));
        }

        [Test]
        public void OneOverThree_Plus_FiveOverSix()
        {
            Assert.That(new Fraction(1, 3) + new Fraction(5, 6), Is.EqualTo(new Fraction(7, 6)));
        }

        [Test]
        public void OneOverFour_Plus_OneOverSix()
        {
            Assert.That(new Fraction(1, 4) + new Fraction(1, 6), Is.EqualTo(new Fraction(5, 12)));
        }

        [Test]
        public void OneOverTwo_Plus_OneOverSix()
        {
            Assert.That(new Fraction(1, 2) + new Fraction(1, 6), Is.EqualTo(new Fraction(2, 3)));
        }

        [Test]
        public void MinusOneOverTwo_Plus_OneOverThree()
        {
            Assert.That(new Fraction(-1, 2) + new Fraction(1, 3), Is.EqualTo(new Fraction(-1, 6)));
        }
    }
}