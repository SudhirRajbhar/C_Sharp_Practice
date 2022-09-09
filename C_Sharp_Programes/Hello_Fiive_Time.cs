using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Five_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr;
            ctr = 0;
            while(ctr<5)
            {
                System.Console.WriteLine("Hello");
                ctr = ctr + 1;
            }
            Console.ReadLine();
        }

    }
}
