using System;
using System.Collections.Generic;
using System.Linq;

namespace FractionsExercise
{
    public class Fraction
    {
        public readonly int Numerator;
        public readonly int Denominator;

        public Fraction(int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator )
        {
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

            Numerator = numerator == 0 ? 0 : numerator / GreatestCommonDivisor(numerator, denominator);
            Denominator = denominator == 0 ? 0 : denominator / GreatestCommonDivisor(numerator, denominator);
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temporary = b;
                b = a % temporary;
                a = temporary;
            }

            return Math.Abs(a);
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
