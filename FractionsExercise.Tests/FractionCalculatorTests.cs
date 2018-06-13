using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionCalculatorTests
    {
        private FractionCalculator _fractionCalculator;

        [SetUp]
        public void SetUp() => _fractionCalculator = new FractionCalculator();

        [Test]
        public void Should_add_zero_fractions()
        {
            Assert.That(_fractionCalculator.Add(new Fraction(0, 0), new Fraction(0, 0)).AsNumber, Is.EqualTo(new Fraction(0, 0).AsNumber));
        }

        [Test]
        public void Should_add_fractions_with_same_denominator()
        {
            Assert.That(_fractionCalculator.Add(new Fraction(1, 4), new Fraction(2, 4)).AsNumber, Is.EqualTo(new Fraction(3, 4).AsNumber));
        }

        [Test]
        public void Should_add_fractions_with_different_denominator()
        {
            Assert.That(_fractionCalculator.Add(new Fraction(1, 4), new Fraction(2, 5)).AsNumber, Is.EqualTo(new Fraction(13, 20).AsNumber));
        }

        [TestCase(3, 2, 5, 2, 8, 2)]
        [TestCase(3, 2, 5, 3, 19, 6)]
        public void Should_add_improper_fractions(int firstAddendNumerator, int firstAddendDenominator, int secondAddendNumerator, int secondAddendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(_fractionCalculator.Add(new Fraction(firstAddendNumerator, firstAddendDenominator), new Fraction(secondAddendNumerator, secondAddendDenominator)).AsNumber, Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator).AsNumber));
        }

        [TestCase(0, 0, 1, 3, 1, 3)]
        [TestCase(7, 2, 0, 0, 7, 2)]
        public void Should_add_fractions_when_one_addend_is_zero(int firstAddendNumerator, int firstAddendDenominator, int secondAddendNumerator, int secondAddendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(_fractionCalculator.Add(new Fraction(firstAddendNumerator, firstAddendDenominator), new Fraction(secondAddendNumerator, secondAddendDenominator)).AsNumber, Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator).AsNumber));
        }
    }
}