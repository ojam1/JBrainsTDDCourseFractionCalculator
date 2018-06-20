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

            Numerator = numerator == 0 ? 0 : numerator / GreatestCommonFactor(GetFactors(numerator), GetFactors(denominator));
            Denominator = denominator == 0 ? 0 : denominator / GreatestCommonFactor(GetFactors(numerator), GetFactors(denominator));
        }

        public void Print()
        {
            Console.WriteLine($"{Numerator}\n-\n{Denominator}");
        }

        private static IEnumerable<int> GetFactors(int number)
        {
            var factorList = new List<int>();
            for (var i = 1; i <= Math.Abs(number); i++)
            {
                if (number%i == 0)
                    factorList.Add(i);
            }

            return factorList;
        }

        private static int GreatestCommonFactor(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            return list1.Where(list2.Contains).Max();
        }

        protected bool Equals(Fraction other)
        {
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Fraction) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Numerator * 397) ^ Denominator;
            }
        }
    }
}
