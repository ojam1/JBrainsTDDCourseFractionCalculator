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
    }
}
