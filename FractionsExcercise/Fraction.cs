using System;
using System.Collections.Generic;
using System.Linq;

namespace FractionsExercise
{
    public class Fraction
    {
        public readonly int Numerator;
        public readonly int Denominator;
        public float AsNumber;

        public Fraction(int numerator, int denominator )
        {
            
            Numerator = numerator == 0 ? 0 : numerator/GreatestCommonFactor(GetFactors(numerator), GetFactors(denominator));
            Denominator = denominator == 0 ? 0 : denominator/ GreatestCommonFactor(GetFactors(numerator), GetFactors(denominator));
            AsNumber = (float)Numerator / (float)Denominator;
        }

        public void Print()
        {
            Console.WriteLine($"{Numerator}\n-\n{Denominator}");
        }

        private static IEnumerable<int> GetFactors(int number)
        {
            var list = new List<int>();
            for (var i = 1; i <= number; i++)
            {
                if (number%i == 0)
                    list.Add(i);
            }

            return list;
        }

        private static int GreatestCommonFactor(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            return list1.Where(list2.Contains).Max();
        }
    }
}
