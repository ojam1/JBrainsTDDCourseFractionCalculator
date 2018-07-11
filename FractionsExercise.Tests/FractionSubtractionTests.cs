using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionSubtractionTests
    {
        [Test]
        public void Should_substract_zero_fractions()
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(0, 0), new Fraction(0, 0)),
                Is.EqualTo(new Fraction(0, 0)));
        }

        [TestCase(0, 3, -3)]
        [TestCase(5, 0, 5)]
        [TestCase(1, 2, -1)]
        public void Should_subtract_whole_numbers(int minuendNumerator, int subtrahendNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(minuendNumerator), new Fraction(subtrahendNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [TestCase(-1, 2, -3)]
        [TestCase(4, -6, 10)]
        public void Should_subtract_negative_whole_numbers(int subtractendNumerator, int augendNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(subtractendNumerator), new Fraction(augendNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [Test]
        public void Should_subtract_fractions_with_same_denominator()
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(4, 5), new Fraction(1, 5)),
                Is.EqualTo(new Fraction(3, 5)));
        }
    }
}
    