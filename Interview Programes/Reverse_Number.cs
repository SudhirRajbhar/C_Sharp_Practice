using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to reverse a number
            // supose we have Number = 1234
            // Reverse of That Number = 4321

            int num = 1234;
            int result = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num / 10; 
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
