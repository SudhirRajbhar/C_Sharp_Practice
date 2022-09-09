using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) -  By Using Third Variable 
            /*
            int a = 10;
            int b = 20;
            int temp;

            Console.WriteLine("Before Swapping value of a = {0}, b={1}",a ,b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping value of a={0},  b={1}",a ,b);
            Console.ReadLine();
            */

            //(2) -  Without Using Third Variable 

            int a = 75;
            int b = 34;

            Console.WriteLine("Before Swapping value of a={0}, b={1}", a, b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping value of a={0}, b={1}", a, b);
            Console.ReadLine();
        }
    }
}
