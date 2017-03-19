using System;
using NUnit.Framework;

namespace Task3.Test
{
    [TestFixture]
    public class NextNumberTests
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        [TestCase(8, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = -1)]
        [TestCase(0, ExpectedResult = -1)]
        [Test]
        public int NextBiggerNumber_PositiveTest(int number)
        {
            return NextNumber.NextBiggerNumber(number);
        }

        [TestCase(-8)]
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        [Test]
        public void NextBiggerNumber_IfNumberNegativeOrMoreThanIntMaxValue_ThrowsArgumentOutOfRangeException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NextNumber.NextBiggerNumber(number));
        }
    }
}
