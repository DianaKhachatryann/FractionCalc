using ConsoleFractionCalc;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();

            fraction1.M=2;
            fraction1.N=8;
            fraction2.M = 3;
            fraction2.N=2;
            Calculator calculator = new Calculator();
            Console.WriteLine( calculator.Plus(fraction1, fraction2));
            Console.WriteLine(calculator.Minus(fraction1, fraction2));
            Console.WriteLine(calculator.Multiply(fraction1, fraction2));
            Console.WriteLine(calculator.Divide(fraction1, fraction2));
            
        }
    }
}
