using NUnit.Framework;

namespace AndreaAngella.Tests
{
    public class MathUtilTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 9, 9)]
        [TestCase(9, 3, 9)]
        [TestCase(2, 3, 6)]
        [TestCase(9, 6, 18)]
        [TestCase(7, 5, 35)]
        public void LowestCommonMultipleTests(int a, int b, int result)
        {
            Assert.That(MathUtil.LowestCommonMultiple(a, b), Is.EqualTo(result));
        }
    }
}
