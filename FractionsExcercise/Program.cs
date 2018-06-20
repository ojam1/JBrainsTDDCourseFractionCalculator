namespace FractionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var fraction = new Fraction(16, 4);
            fraction.Print();
            FractionCalculator.Add(new Fraction(1231243, 44545), new Fraction(3232, 3344)).Print();
        }
    }
}
