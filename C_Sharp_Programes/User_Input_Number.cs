using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First_Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second_Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: {0}", num1+num2);
            Console.WriteLine("Subtraction: {0}", num1 - num2);
            Console.WriteLine("Multiplication: {0}", num1 * num2);
            Console.WriteLine("Division: {0}", num1 / num2);
            Console.WriteLine("Modulus: {0}", num1 % num2);

            Console.ReadLine();
        }
    }
}
