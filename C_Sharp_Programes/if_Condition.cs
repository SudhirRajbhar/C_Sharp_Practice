using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            if (condition)
            {
                // block of code to be executed if the condition is True
            }
            */
            int x = 10;
            int y = 5;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
                Console.ReadLine();
            }
        }
    }
}
