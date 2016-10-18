using System;
using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionCreationTests
    {
        [Test]
        public void ZeroDenominator()
        {
            Assert.Throws<ArgumentException>(() => new Fraction(5, 0));
        }
    }
}
