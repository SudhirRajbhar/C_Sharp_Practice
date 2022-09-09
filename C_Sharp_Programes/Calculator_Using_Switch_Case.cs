using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Using_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.WriteLine("Enter First Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Symbol(+,-,*,/):");
                string Symbol = Console.ReadLine();

                switch (Symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Adddtion:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Do You Want To Continue(Press y For Yes and Pres n For No)");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
