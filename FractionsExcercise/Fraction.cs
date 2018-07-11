using System;

namespace FractionsExercise
{
    public class Fraction
    {
        public readonly int Numerator;
        public readonly int Denominator;

        public Fraction(int numerator) : this(numerator, 1) { }

        public Fraction(int numerator, int denominator )
        {
            if (numerator == 0 || denominator == 0)
            {
                Numerator = 0;
                Denominator = 0;
                return;
            }

            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }

            else if (denominator < 0)
            {
                numerator = -Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }

            Numerator = numerator / GreatestCommonDivisor(numerator, denominator);
            Denominator = denominator / GreatestCommonDivisor(numerator, denominator);
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        private static int GreatestCommonDivisor(int firstNumber, int secondNumber)
        {
            while (secondNumber != 0)
            {
                var temporary = secondNumber;
                secondNumber = firstNumber % temporary;
                firstNumber = temporary;
            }

            return Math.Abs(firstNumber);
        }

        #region Equality

        protected bool Equals(Fraction other)
        {
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Fraction)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Numerator * 397) ^ Denominator;
            }
        }

        #endregion

        public override string ToString()
        {
            return Denominator == 1 ? $"{Numerator}" : $"{Numerator}/{Denominator}";
        }
    }
}
