using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionDivisionTests
    {

        [Test]
        public void Should_divide_zero_fractions()
        {
            Assert.That(FractionCalculator.Divide(new Fraction(0, 0), new Fraction(0, 0)),
                Is.EqualTo(new Fraction(0, 0)));
        }

        [TestCase(0, 3, 0, 0)]
        [TestCase(5, 0, 0, 0)]
        [TestCase(1, 2, 1, 2)]
        public void Should_divide_whole_numbers(int dividendNumerator, int divisorNumerator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Divide(new Fraction(dividendNumerator), new Fraction(divisorNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(-1, 2, -1, 2)]
        [TestCase(4, -6, -2, 3)]
        public void Should_divide_negative_whole_numbers(int dividendNumerator, int divisorNumerator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Divide(new Fraction(dividendNumerator), new Fraction(divisorNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [Test]
        public void Should_divide_fractions_with_same_denominator()
        {
            Assert.That(FractionCalculator.Divide(new Fraction(4, 5), new Fraction(1, 5)),
                Is.EqualTo(new Fraction(4)));
        }

        [Test]
        public void Should_divide_fractions_with_different_denominator()
        {
            Assert.That(FractionCalculator.Divide(new Fraction(3, 4), new Fraction(2, 5)),
                Is.EqualTo(new Fraction(15, 8)));
        }

        [TestCase(3, 2, 6, 2, 1, 2)]
        [TestCase(3, 2, 5, 3, 9, 10)]
        public void Should_divide_improper_fractions(int dividendNumerator, int dividendDenominator, int divisorNumerator, int divisorDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Divide(new Fraction(dividendNumerator, dividendDenominator), new Fraction(divisorNumerator, divisorDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(0, 0, 1, 3, 0, 0)]
        [TestCase(7, 2, 0, 0, 0, 0)]
        public void Should_return_a_zero_fraction_when_one_fraction_is_zero(int dividendNumerator, int dividendDenominator, int divisorNumerator, int divisorDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Divide(new Fraction(dividendNumerator, dividendDenominator), new Fraction(divisorNumerator, divisorDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(-1, 2, 1, 3, -3, 2)]
        [TestCase(2, -3, 2, 6, -2, 1)]
        [TestCase(1, 4, -3, -8, 2, 3)]
        public void Should_divide_negative_fractions(int dividendNumerator, int dividendDenominator, int divisorNumerator, int divisorDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Divide(new Fraction(dividendNumerator, dividendDenominator), new Fraction(divisorNumerator, divisorDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }
    }
}
