using System;
using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class FractionTests
    {
        [Test]
        public void FiveOverZero_IsInvalid()
        {
            Assert.Throws<ArgumentException>(() => new Fraction(5, 0));
        }
    }
}
