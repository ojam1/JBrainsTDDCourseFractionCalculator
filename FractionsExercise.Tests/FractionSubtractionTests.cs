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
        public void Should_subtract_negative_whole_numbers(int minuendNumerator, int subtrahendNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(minuendNumerator), new Fraction(subtrahendNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [Test]
        public void Should_subtract_fractions_with_same_denominator()
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(4, 5), new Fraction(1, 5)),
                Is.EqualTo(new Fraction(3, 5)));
        }

        [Test]
        public void Should_subtract_fractions_with_different_denominator()
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(3, 4), new Fraction(2, 5)),
                Is.EqualTo(new Fraction(7, 20)));
        }

        [TestCase(3, 2, 6, 2, -3, 2)]
        [TestCase(3, 2, 5, 3, -1, 6)]
        public void Should_subtract_improper_fractions(int minuendNumerator, int minuendDenominator, int subtrahendNumerator, int subtrahendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(minuendNumerator, minuendDenominator), new Fraction(subtrahendNumerator, subtrahendDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(0, 0, 1, 3, -1, 3)]
        [TestCase(7, 2, 0, 0, 7, 2)]
        public void Should_subtract_fractions_when_one_subtractend_is_zero(int minuendNumerator, int minuendDenominator, int subtrahendNumerator, int subtrahendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(minuendNumerator, minuendDenominator), new Fraction(subtrahendNumerator, subtrahendDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(-1, 2, 1, 3, -5, 6)]
        [TestCase(2, -3, 2, 6, -1, 1)]
        [TestCase(1, 4, -3, -8, -1, 8)]
        public void Should_subtract_negative_fractions(int minuendNumerator, int minuendDenominator, int subtrahendNumerator, int subtrahendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Subtract(new Fraction(minuendNumerator, minuendDenominator), new Fraction(subtrahendNumerator, subtrahendDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }
    }
}
    