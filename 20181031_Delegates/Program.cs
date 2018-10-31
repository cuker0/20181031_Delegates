using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181031_Delegates
{
   
    static class Program
    {
        static void Main(string[] args)
        {
            
            SimpleDelegateTest();
          
            Console.ReadKey();          
        }

        private static void SimpleDelegateTest()
        {
            Action<double, double> del = Math.Add; //stworzenie domyslnej delegaty
          //  callDelegate(del);
            del += Math.Substract; // przypisane kolejnej metody do delegaty
            callDelegate(del);

            Action<double, double> delExpLambda = (a, b) => { Console.WriteLine($"{a} * {b} = {a * b}"); };
            callDelegate(del);

            // del += (a, b) => { Console.WriteLine($"{a} * {b} = {a * b}"); }; //wyrazenie lambda wywolana jak metoda

            del += delExpLambda;
                    
            callDelegate(del);
            del -= delExpLambda;
            callDelegate(del);

            

            // del = null; // wyczyszczenie delegat
            // del?.Invoke(0,0);
            // callDelegate(del);
        }

        private static void callDelegate(Action<double, double> del)
        {
            Console.WriteLine("################################");
            del(10, 2);
        }
    }
}
