namespace FractionsExercise
{
    public class FractionCalculator
    {
        public static Fraction Add(Fraction addend, Fraction augend)
        {
            int newNumerator;

            if (AdditionFromAnyZeroFractionInCalcualtion(addend, augend) != null)
                return AdditionFromAnyZeroFractionInCalcualtion(addend, augend);

            if (DenominatorsDifferent(addend, augend))
            {
                var newDenominator = addend.Denominator * augend.Denominator;

                newNumerator = addend.Numerator * augend.Denominator +
                               augend.Numerator * addend.Denominator;

                return new Fraction(newNumerator, newDenominator);
            }

            newNumerator = addend.Numerator + augend.Numerator;

            return new Fraction(newNumerator, addend.Denominator);
        }

        public static Fraction Subtract(Fraction minuend, Fraction subtrahend)
        {
            int newNumerator;

            if (SubtractionFromAnyZeroFractionInCalcualtion(minuend, subtrahend) != null)
                return SubtractionFromAnyZeroFractionInCalcualtion(minuend, subtrahend);

            if (DenominatorsDifferent(minuend, subtrahend))
            {
                var newDenominator = minuend.Denominator * subtrahend.Denominator;

                newNumerator = minuend.Numerator * subtrahend.Denominator -
                               subtrahend.Numerator * minuend.Denominator;

                return new Fraction(newNumerator, newDenominator);
            }

            newNumerator = minuend.Numerator - subtrahend.Numerator;

            return new Fraction(newNumerator, minuend.Denominator);
        }

        public static Fraction Multiply(Fraction multiplicand, Fraction multiplier)
        {
            if (IsFractionZero(multiplicand) || IsFractionZero(multiplier))
                return new Fraction(0, 0);

            var newNumerator = multiplicand.Numerator * multiplier.Numerator;

            var newDenominator = multiplicand.Denominator * multiplier.Denominator;

            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction Divide(Fraction dividend, Fraction divisor)
        {
            if (IsFractionZero(dividend) || IsFractionZero(divisor))
                return new Fraction(0, 0);

            return new Fraction(0, 0);
        }

        private static bool DenominatorsDifferent(Fraction firstFraction, Fraction secondFraction)
        {
            return firstFraction.Denominator != secondFraction.Denominator;
        }

        private static bool IsFractionZero(Fraction fraction)
        {
            return fraction.Equals(new Fraction(0, 0));
        }

        private static Fraction AdditionFromAnyZeroFractionInCalcualtion(Fraction firstFractionInCalculation, Fraction secondFractionInCalculation)
        {
            if (IsFractionZero(firstFractionInCalculation))
                return secondFractionInCalculation;

            if (IsFractionZero(secondFractionInCalculation))
                return firstFractionInCalculation;

            if (IsFractionZero(firstFractionInCalculation) && IsFractionZero(secondFractionInCalculation))
                return new Fraction(0, 0);

            return null;
        }

        private static Fraction SubtractionFromAnyZeroFractionInCalcualtion(Fraction firstFractionInCalculation, Fraction secondFractionInCalculation)
        {
            if (IsFractionZero(firstFractionInCalculation))
                return new Fraction(-secondFractionInCalculation.Numerator, secondFractionInCalculation.Denominator);

            if (IsFractionZero(secondFractionInCalculation))
                return firstFractionInCalculation;

            if (IsFractionZero(firstFractionInCalculation) && IsFractionZero(secondFractionInCalculation))
                return new Fraction(0, 0);

            return null;
        }
    }
}
