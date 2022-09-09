using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type__Of_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //(1) - Arithmatic Operator -> These are used to perform Arithmatic / Mathematic operation on Operands
            int a = 10, b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadLine();
            */

            /*
            //(2) - Unary Oerator -> They are also Arithmatic Operators

            int i = 0; // initialization

            // ++i; // prefix increment by +1
            // i++; // postfix increment by +1

            //--i; // prifix decrement by -1
            i--; // postfix decrement by -1

            Console.WriteLine("{0}", i);
            Console.ReadLine();
            */

            /*
            //(3) - Assignment Operator -> These are used to assigning  avalue to a  variable. The Left side Operand of the assignment operator is variable  and right side operand of the assign operator is a value.
            int a = 10, b = 5;
            Console.WriteLine(a += b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a /= b);
            Console.WriteLine(a %= b);
            Console.ReadLine();
            */

            /*
            //(4) - Relational Operator -> Relational opeartors are used for comparison of two values So They are also called comparison operators 
            int a = 10, b = 5;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.ReadLine();
            */

            /*
            //(5) - Logical Operator -> Relational opeartors are used for comparison of two values So They are also called comparison operators 
            int a = 10, b = 5, c = 10;

            Console.WriteLine(a == b && a == c);
            Console.WriteLine(a == b || a == c);
            Console.WriteLine(!(a == b || a == c));
            Console.ReadLine();
            */

            //(6) - Bitwise  Operator -> Bitwise operator are used to perform indivisual bits of a number.it can be used integer type values not float, double etc.
            int a = 1, b = 2;
            int bitAnd = a & b;
            Console.WriteLine(bitAnd);

            int bitOr = a | b;
            Console.WriteLine(bitOr);

            int bitNot = ~b;
            Console.WriteLine(bitNot);

            int bitRightShift = a >> b;
            Console.WriteLine(bitRightShift);


            int bitLeftShift = a << b;
            Console.WriteLine(bitLeftShift);

            Console.ReadLine();

        }
    }
}
