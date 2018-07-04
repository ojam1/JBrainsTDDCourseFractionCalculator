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
    }
}
