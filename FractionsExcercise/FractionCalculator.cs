namespace FractionsExercise
{
    public class FractionCalculator
    {
        public static Fraction Add(Fraction addend, Fraction augend)
        {
            int newNumerator;

            if (AdditionFromAnyZeroFractionInCalcualtion(addend, augend) != null)
                return AdditionFromAnyZeroFractionInCalcualtion(addend, augend);

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

        private static Fraction AdditionFromAnyZeroFractionInCalcualtion(Fraction addend, Fraction augend)
        {
            if (IsFractionZero(addend))
                return augend;

            if (IsFractionZero(augend))
                return addend;

            if (IsFractionZero(addend) && IsFractionZero(augend))
                return new Fraction(0, 0);

            return null;
        }

        private static bool IsFractionZero(Fraction fraction)
        {
            return fraction.Equals(new Fraction(0, 0));
        }
    }
}
