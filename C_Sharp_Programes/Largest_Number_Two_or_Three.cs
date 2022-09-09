using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_Two_or_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) - Largest Number Between Two Numbers
            /*
            int a = 10;
            int b = 20;
            
            if(a>b)
            {
                Console.WriteLine(" a is greatest");
            }
            else
            {
                Console.WriteLine(" b is greatest");
            }
            Console.ReadLine();
            */

            // (2) - Largest Number Between Three Numbers
            /*
            int a = 10;
            int b = 20; 
            int c = 10;

            if(a>b && a>c)
            {
                Console.WriteLine(" a is greater");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine(" a is greater");
            }
            else
            {
                Console.WriteLine(" c is greatest");
            }
            Console.ReadLine();
            */

            // (3) - Largest Number Between Three Numbers

            int a = 10;
            int b = 20;
            int c = 10;

            if(a > b)
            {
                if(a>c)
                {
                    Console.WriteLine(" a is greater");
                }
                else
                {
                    Console.WriteLine(" c is greater");
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine(" b is greater ");
                }
                else
                {
                    Console.WriteLine(" c is greater ");
                }
            }
            Console.ReadLine();
        }
    }
}
