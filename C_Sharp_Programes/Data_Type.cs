using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            // datatype = byte , int , float , double , decimal , char , bool

            byte b = 1;                 // VariableName = b || value = 1
            int i = 100;
            float f = 2.5F;             // 'F' suffix(is mandatory) to create a literal of this type
            double h = 3.7;             // 'D' suffix(You can Add)
            decimal d = 3.14M;          // 'M' suffix(is mandatory) to create a literal of this type
            char c = 'S';                // only one char use 'S'
            bool l = true;              // True / False

            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(l);
            Console.ReadLine();
        }
    }
}
