using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Print_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr;
            ctr = 0;
            do
            {
                System.Console.WriteLine("Sudhir Rajbhar");
                ctr = ctr + 1;
            }
            while (ctr < 5);
            Console.ReadLine();
        }
    }
}
