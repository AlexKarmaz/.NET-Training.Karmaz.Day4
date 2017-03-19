using System;
using NUnit.Framework;

namespace Task4.Test
{
    [TestFixture]
    public class NewtonMethodTests
    {
        [TestCase(0.015625, 3, 0.0000001, ExpectedResult = 0.25)]
        [TestCase(9, 2, 0.00001, ExpectedResult = 3)]
        [TestCase(438976, 3, 0.00000000000001, ExpectedResult = 76)]
        [Test]
        public double Sqrt_PositiveTest(double number, int n, double precision = 0.000001)
        {
            return NewtonMethod.Sqrt(number, n, precision);
        }

        [TestCase(-444, 4, 0.000001)]
        [TestCase(0.0000002, 2, 0.00001)]
        [Test]
        public void Sqrt_ThrowsArgumentException(double number, int n, double precision)
        {
            Assert.Throws<ArgumentException>(() => NewtonMethod.Sqrt(number, n, precision));
        }

        [TestCase(-5432, 4, 2)]
        [TestCase(-5432, 4, 1e-16)]
        [TestCase(-5432, -3, 0.000001)]
        [Test]
        public void Sqrt_ThrowsArgumentOutOfRangeException(double number, int n, double precision)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NewtonMethod.Sqrt(number, n, precision));
        }
    }
}
