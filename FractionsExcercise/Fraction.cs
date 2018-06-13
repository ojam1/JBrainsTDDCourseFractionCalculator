using System.Dynamic;

namespace FractionsExcercise
{
    public class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;
        public float AsNumber;

        public Fraction(int numerator, int denominator )
        {
            _numerator = numerator;
            _denominator = denominator;
            AsNumber = (_numerator == 0 && _denominator == 0) ? 0 : _numerator / _denominator;
        }
    }
}
