using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            // It is series of Number that from 0 and 1. Next Number in series is the Sum of last two Numbers
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i <= 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
    //Output :- 0 1 1 2 3 5 8 13 21 34 55 89 144
}