using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181031_Delegates
{
    delegate void MathDelegate(double a, double b);

    static class Math
    {
      
        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        
        public static void Substract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

    }
}
