using ConsoleFractionCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19;
class Calculator
{
    public string Plus(Fraction a1,Fraction a2)
    {
        Fraction plus = new Fraction();
        plus.M = (a1.M * a2.N) + (a1.N + a2.M);
        plus.N= a1.N  * a2.N;
        return $"{plus.M}/{plus.N}";
    }
    public string Minus(Fraction a1, Fraction a2)
    {
        Fraction minus = new Fraction();
        minus.M = (a1.M * a2.N) + (a1.N + a2.M);
        minus.N = a1.N * a2.N;
        return $"{minus.M}/{minus.N}";

    }
    public string Multiply (Fraction a1, Fraction a2)
    {
        Fraction mul = new Fraction();
        mul.M = (a1.M * a2.M);
        mul.N = a1.N * a2.N;
        return $"{mul.M}/{mul.N}";

    }
    public string Divide(Fraction a1, Fraction a2)
    {
        Fraction div = new Fraction();
        div.M = (a1.M * a2.N);
        div.N = a2.M * a1.N;
        return $"{div.M}/{div.N}";

    }

}
