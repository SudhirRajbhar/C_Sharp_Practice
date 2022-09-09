using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("The sum of digit is :{0}",sum);
            Console.ReadLine();
        }
    }
}
