using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            string last_name;

            Console.Write("Enter Your First Name:");
            first_name = Console.ReadLine();

            Console.Write("Enter Your Second Name:");
            last_name = Console.ReadLine();


            //Console.WriteLine("First Name:" + first_name);
            //Console.WriteLine("Last Last:" + last_name);

            //Console.WriteLine("Hello,Mr." + first_name + last_name);
            Console.WriteLine("Hello,Mr.{0} {1}", first_name, last_name);
            Console.ReadLine();
        }
    }
}
