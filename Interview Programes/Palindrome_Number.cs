using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Palindrome number is  a number that remains the some its digit are reversed
            //Reverse of Number 121 = 121
            //Reverse of Number 16416 = 16416

            int number = 12321;    //1234321 
            int rem;
            int result = 0;
            int temp = number;

            while (number != 0)
            {
                rem = number % 10;
                result = result * 10 + rem;
                number = number / 10;
            }
   
            number = temp;
            if (number == result)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
