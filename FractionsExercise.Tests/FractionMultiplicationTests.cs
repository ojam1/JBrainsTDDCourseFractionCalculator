﻿using NUnit.Framework;

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

        [Test]
        public void Should_multiply_fractions_with_different_denominator()
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(1, 4), new Fraction(2, 5)),
                Is.EqualTo(new Fraction(1, 10)));
        }

        [TestCase(3, 2, 5, 2, 15, 4)]
        [TestCase(3, 2, 5, 3, 15, 6)]
        public void Should_multiply_improper_fractions(int multiplicandNumerator, int multiplicandDenominator, int multiplierNumerator, int multiplierDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(multiplicandNumerator, multiplicandDenominator), new Fraction(multiplierNumerator, multiplierDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(0, 0, 1, 3, 0, 0)]
        [TestCase(7, 2, 0, 0, 0, 0)]
        public void Should_return_a_zero_fraction_when_one_factor_is_zero(int multiplicandNumerator, int multiplicandDenominator, int multiplierNumerator, int multiplierDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(multiplicandNumerator, multiplicandDenominator), new Fraction(multiplierNumerator, multiplierDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }

        [TestCase(-1, 2, 1, 3, -1, 6)]
        [TestCase(2, -3, 2, 6, -2, 9)]
        [TestCase(1, 4, -2, -8, 1, 16)]
        public void Should_multiply_negative_fractions(int multiplicandNumerator, int multiplicandDenominator, int multiplierNumerator, int multiplierDenominator, int expectedNumerator, int expectedDenominator)
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(multiplicandNumerator, multiplicandDenominator), new Fraction(multiplierNumerator, multiplierDenominator)),
                Is.EqualTo(new Fraction(expectedNumerator, expectedDenominator)));
        }
    }
}
