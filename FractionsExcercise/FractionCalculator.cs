namespace FractionsExercise
{
    public class FractionCalculator
    {
        public Fraction Add(Fraction firstAddend, Fraction secondAddend)
        {
            int newNumerator;
            
            if (IsFractionZero(firstAddend) && IsFractionZero(secondAddend))
                return new Fraction(0, 0);

            if (firstAddend.Denominator != secondAddend.Denominator)
            {
                var newDenominator = firstAddend.Denominator * secondAddend.Denominator;

                newNumerator = (firstAddend.Denominator * secondAddend.Numerator) +
                               (secondAddend.Denominator * firstAddend.Numerator);

                return new Fraction(newNumerator, newDenominator);
            }

            newNumerator = firstAddend.Numerator + secondAddend.Numerator;

            return new Fraction(newNumerator, firstAddend.Denominator);
        }

        private static bool IsFractionZero(Fraction fraction)
        {
            return fraction.AsNumber.Equals(0);
        }
    }
}
