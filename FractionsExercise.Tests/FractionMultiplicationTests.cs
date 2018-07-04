using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionMultiplicationTests
    {
        [Test]
        public void Should_multiply_zero_fractions()
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(0, 0), new Fraction(0, 0)),
                Is.EqualTo(new Fraction(0, 0)));
        }

        [TestCase(0, 3, 0)]
        [TestCase(5, 0, 0)]
        [TestCase(1, 2, 2)]
        public void Should_multiply_whole_numbers(int multiplicandNumerator, int multiplierNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(multiplicandNumerator), new Fraction(multiplierNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [TestCase(-1, 2, -2)]
        [TestCase(3, -2, -6)]
        public void Should_multiply_negative_whole_numbers(int multiplicandNumerator, int multiplierNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(multiplicandNumerator), new Fraction(multiplierNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [Test]
        public void Should_multiply_fractions_with_same_denominator()
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(1, 4), new Fraction(2, 4)),
                Is.EqualTo(new Fraction(1, 8)));
        }
    }
}
