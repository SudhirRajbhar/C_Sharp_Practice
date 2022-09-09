using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_from_User_input
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = new int[10];
            int i;
          

            Console.Write("Input any Element in the array :\n");
            for (i = 0; i < 10; i++)
            {
                //Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            */

            /*
            int size = Convert.ToInt32(Console.In.ReadLine());
            int [] grades  = new int[size];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for ( int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i] + " ");
            }
            */


            /*
            int [] newarray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                newarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine("Entered Your Number with Index [{0}] = {1}", j ,newarray[j]);
            }
            Console.ReadLine();
            */

            /*
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Your Entered = " + array[i]);
            }
            */


            string [] array = new string[5];

            for(int i = 0; i < 5; i++)
            {
                array[i] = Console.ReadLine();
                Console.WriteLine("Your Name: = " + array[i]);
            }

        }
    }
    
}
