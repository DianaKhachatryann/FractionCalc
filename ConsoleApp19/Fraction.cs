using ConsoleApp19;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFractionCalc;

struct Fraction
{
   public int  N {  get; set; }
   public int M {  get; set; }

    public void Validate(int n, int m)
    {
        if(n > 0)
        {
           
        }
        else
        {
            Console.WriteLine("the number is invalid");
        }
    }
}
