using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_9
{
    // *****
    //  ****
    //   ***
    //    **
    //     *

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
