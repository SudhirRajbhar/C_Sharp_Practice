using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Pyramid_Diamond_14
{
    //     *
    //    ***
    //   *****
    //  *******
    // *********
    //  *******
    //   *****
    //    ***
    //     *
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for (int j = i; j <=4; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 2; i <= 5; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 2*i-1; k <= 9; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}
