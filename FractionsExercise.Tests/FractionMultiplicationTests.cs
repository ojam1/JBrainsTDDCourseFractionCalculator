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
        public void Should_multiply_whole_numbers(int addendNumerator, int augendNumerator, int expectedNumerator)
        {
            Assert.That(FractionCalculator.Multiply(new Fraction(addendNumerator), new Fraction(augendNumerator)),
                Is.EqualTo(new Fraction(expectedNumerator)));
        }
    }
}
