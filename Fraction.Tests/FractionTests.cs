using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionTests
    {
        [Test]
        public void FractionZero_Plus_FractionZero()
        {
            var f1 = new Fraction(0);
            var f2 = new Fraction(0);

            var result = new Fraction(0);

            Assert.That(f1 + f2, Is.EqualTo(result));
        }

        [Test]
        public void Zero_Plus_FractionZero()
        {
            var a = 0;
            var b = new Fraction(0);

            var result = new Fraction(0);

            Assert.That(a + b, Is.EqualTo(result));
        }
    }
}
