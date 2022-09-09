using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Casting  is when you assign a value of one data type to another type
            // (1) Implicit casting (Automatically) -  converting to Smaller to Larger type size => The the Compiler
            // char -> int -> long -> float -> double
            
            int a = 7;
            double b = a;                // Automatic casting: int to double

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
            

            // (2) Explicit casting (Manually) -  converting to Larger to Smaller type size => The the Programmer 

            
            double d= 9.78;
            int c = (int)d;             // Manual casting: double to int

            Console.WriteLine(d);      // Outputs 9.78
            Console.WriteLine(c);      // Outputs 9
            Console.ReadLine();


            //Type Conversion Methods

            int e = 10;
            double f = 5.25;
            bool g = true;

            Console.WriteLine(Convert.ToString(e));    // convert int to string
            Console.WriteLine(Convert.ToDouble(e));    // convert int to double
            Console.WriteLine(Convert.ToInt32(f));     // convert double to int
            Console.WriteLine(Convert.ToString(g));    // convert bool to string
            Console.WriteLine(Convert.ToBoolean(e));   // convert string to Booleam
            Console.WriteLine(Convert.ToInt64(g));     // convert Boolean to int
            Console.ReadLine();
        }
    }
}
