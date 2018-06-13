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
        public void Should_express_fraction_in_lowest_term(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            var fraction = new Fraction(numerator, denominator);

            Assert.True(
                (fraction.Numerator == expectedNumerator) &&
                (fraction.Denominator == expectedDenominator)
                );
        }
    }
}
