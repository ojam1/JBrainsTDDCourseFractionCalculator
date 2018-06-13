namespace FractionsExcercise
{
    public class FractionCalculator
    {
        public Fraction Add(Fraction firstAddend, Fraction secondAddend)
        {
            if (IsFractionZero(firstAddend) && IsFractionZero(secondAddend))
                return new Fraction(0, 0);

            var newNumerator = firstAddend.Numerator + secondAddend.Numerator;
            return new Fraction(newNumerator, firstAddend.Denominator);
        }

        private static bool IsFractionZero(Fraction fraction)
        {
            return fraction.AsNumber.Equals(0);
        }
    }
}
