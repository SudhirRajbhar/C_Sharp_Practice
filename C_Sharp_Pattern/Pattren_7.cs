﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_7
{
    class Program
    {
        // 1
        // 23
        // 456
        // 78910
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
