using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionCalculatorTests
    {
        [Test]
        public void Should_add_zero_fractions()
        {
            Assert.That(FractionCalculator.Add(new Fraction(0, 0), new Fraction(0, 0)),
                Is.EqualTo(new Fraction(0, 0)));
        }

        [Test]
        public void Should_add_fractions_with_same_denominator()
        {
            Assert.That(FractionCalculator.Add(new Fraction(1, 4), new Fraction(2, 4)),
                Is.EqualTo(new Fraction(3, 4)));
        }

        [Test]
        public void Should_add_fractions_with_different_denominator()
        {
            Assert.That(FractionCalculator.Add(new Fraction(1, 4), new Fraction(2, 5)),
                Is.EqualTo(new Fraction(13, 20)));
        }

        [TestCase(3, 2, 5, 2, 8, 2)]
        [TestCase(3, 2, 5, 3, 19, 6)]
        public void Should_add_improper_fractions(int addendNumerator, int addendDenominator, int augendNumerator, int augendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Add(new Fraction(addendNumerator, addendDenominator), new Fraction(augendNumerator, augendDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(0, 0, 1, 3, 1, 3)]
        [TestCase(7, 2, 0, 0, 7, 2)]
        public void Should_add_fractions_when_one_addend_is_zero(int addendNumerator, int addendDenominator, int augendNumerator, int augendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Add(new Fraction(addendNumerator, addendDenominator), new Fraction(augendNumerator, augendDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(0, 3, 3)]
        [TestCase(5, 0, 5)]
        [TestCase(1, 2, 3)]
        public void Should_add_whole_numbers(int addendNumerator, int augendNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Add(new Fraction(addendNumerator), new Fraction(augendNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [TestCase(-1, 2, 1)]
        [TestCase(4, -6, -2)]
        public void Should_add_negative_whole_numbers(int addendNumerator, int augendNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Add(new Fraction(addendNumerator), new Fraction(augendNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }

        [TestCase(-1, 2, 1, 3, -1, 6)]
        [TestCase(2, -3, 2, 6, -1, 3)]
        [TestCase(1, 4, -2, -8, 1, 2)]
        public void Should_add_negative_fractions(int addendNumerator, int addendDenominator, int augendNumerator, int augendDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Add(new Fraction(addendNumerator, addendDenominator), new Fraction(augendNumerator, augendDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }
    }
}