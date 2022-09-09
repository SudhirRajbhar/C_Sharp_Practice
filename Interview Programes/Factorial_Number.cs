using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial Of Given Number is Mulyiplication Of All the intergers from 1 to given Number
            int num = 4;
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
