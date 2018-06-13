using FractionsExcercise;
using NUnit.Framework;

namespace FractionsExercise.Tests
{
    [TestFixture]
    public class FractionTests
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
    }
}