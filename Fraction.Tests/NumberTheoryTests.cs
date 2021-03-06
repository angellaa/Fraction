﻿using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class NumberTheoryTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 9, 9)]
        [TestCase(9, 3, 9)]
        [TestCase(2, 3, 6)]
        [TestCase(9, 6, 18)]
        [TestCase(7, 5, 35)]
        public void LowestCommonMultiple(int a, int b, int result)
        {
            Assert.That(NumberTheory.LowestCommonMultiple(a, b), Is.EqualTo(result));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 1, 1)]
        [TestCase(1, 2, 1)]
        [TestCase(3, 9, 3)]
        [TestCase(9, 3, 3)]
        [TestCase(20, 25, 5)]
        [TestCase(12, 18, 6)]
        [TestCase(24, 60, 12)]
        public void GreatestCommonDivisor(int a, int b, int result)
        {
            Assert.That(NumberTheory.GreatestCommonDivisor(a, b), Is.EqualTo(result));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(5)]
        public void PosibiveAbs(int a)
        {
            Assert.That(NumberTheory.Abs(a), Is.EqualTo(a));
        }

        [TestCase(-1)]
        [TestCase(-5)]
        public void NegativeAbs(int a)
        {
            Assert.That(NumberTheory.Abs(a), Is.EqualTo(-a));
        }
    }
}
