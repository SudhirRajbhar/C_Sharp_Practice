using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "Hello";
            Console.WriteLine(str);

            string txt = "SUDHIR";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string name = "Sudhir Rajbhar";
            Console.WriteLine(name.ToUpper());   
            Console.WriteLine(name.ToLower());

            //String Concatenation
            string firstName = "Rahul ";
            string lastName = "Vishvkarma";
            string myname = firstName + lastName;
            Console.WriteLine(myname);
            */

            /*
            //String Interpolation
            string firstName = "Pravesh";
            string lastName = "Bharadwaj";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.ReadLine();
            */

            /*
            //Access Strings
            string myString = "Sudhir";
            Console.WriteLine(myString[0]);
            Console.ReadLine();
            */


            //using the IndexOf() method:
            string myString = "Sudhir";
            Console.WriteLine(myString.IndexOf("d")); 
            Console.ReadLine();
        }
    }
}
