using System.Dynamic;

namespace FractionsExcercise
{
    public class Fraction
    {
        public readonly int Numerator;
        public readonly int Denominator;
        public float AsNumber;

        public Fraction(int numerator, int denominator )
        {
            Numerator = numerator;
            Denominator = denominator;
            AsNumber = (Numerator == 0 && Denominator == 0) ? 0 : (float)Numerator / (float)Denominator;
        }
    }
}
