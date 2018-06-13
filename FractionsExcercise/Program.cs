using System;

namespace FractionsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Fraction(0, 0).AsNumber);
            Console.WriteLine(new Fraction(3, 4).AsNumber);
        }
    }
}
