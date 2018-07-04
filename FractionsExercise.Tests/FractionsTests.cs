using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionsTests
    {
        [TestCase(1, 2, 1, 2)]
        [TestCase(5, 10, 1, 2)]
        [TestCase(16, 4, 4, 1)]
        [TestCase(30, 8, 15, 4)]
        [TestCase(0, 0, 0, 0)]
        public void Should_express_fraction_in_lowest_term(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(new Fraction(numerator, denominator),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 0, 0, 0)]
        [TestCase(0, 1, 0, 0)]
        public void Should_handle_zero_in_fraction(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(new Fraction(numerator, denominator),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }
    }
}
