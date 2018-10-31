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
            MathDelegate del = new MathDelegate(Math.Add); //stworzenie domyslnej delegaty
            callDelegate(del);
            del += Math.Substract; // przypisane kolejnej metody do delegaty
            callDelegate(del);

            del = null; // wyczyszczenie delegat
            del?.Invoke(0,0);
            callDelegate(del);
        }

        private static void callDelegate(MathDelegate del)
        {
            Console.WriteLine("################################");
            del(10, 2);
        }
    }
}
