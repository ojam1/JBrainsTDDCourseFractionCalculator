namespace FractionsExercise
{
    public class FractionCalculator
    {
        public static Fraction Add(Fraction addend, Fraction augend)
        {
            int newNumerator;

            if (IsFractionZero(addend))
                return augend;

            if (IsFractionZero(augend))
                return addend;
            
            if (IsFractionZero(addend) && IsFractionZero(augend))
                return new Fraction(0, 0);

            if (addend.Denominator != augend.Denominator)
            {
                var newDenominator = addend.Denominator * augend.Denominator;

                newNumerator = (addend.Denominator * augend.Numerator) +
                               (augend.Denominator * addend.Numerator);

                return new Fraction(newNumerator, newDenominator);
            }

            newNumerator = addend.Numerator + augend.Numerator;

            return new Fraction(newNumerator, addend.Denominator);
        }

        private static bool IsFractionZero(Fraction fraction)
        {
            return fraction.AsNumber.Equals(0);
        }
    }
}
