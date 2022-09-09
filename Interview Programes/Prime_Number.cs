using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) Check Prime Number
            /*
            int number = 7;
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i==0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
            */

            // (2) Find Prime Number Between 1 to 100
               
              for(int number = 1; number <= 100; number++)
              {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }

                     if (count == 2)
                     {
                       Console.WriteLine(number);
                     }
              }
              Console.ReadLine();
        }
    }
}
