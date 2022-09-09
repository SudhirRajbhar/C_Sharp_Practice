using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armstrong number is a number that is equal to the sum of cubes of its digit
            //For example : 153 is Armstrong Number
            // 1^3 + 5^3 + 3^3

            int number = 153;  //0, 1, 153, 370, 371 and 407
            int rem;
            int cube;
            int result = 0;
            int temp = number;

            while(number != 0)
            {
                rem = number % 10;
                cube = rem * rem * rem;
                result = result + cube;
                number = number / 10;
            }
            number = temp;
            if(number == result)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
