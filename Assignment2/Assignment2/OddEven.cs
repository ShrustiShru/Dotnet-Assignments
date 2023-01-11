using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the numbers");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            //////////////Display array elements//////////
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Entered elements are: ");
            foreach (var item in array)
            {
                Console.Write(item+" " + "\n");
            }


            Console.WriteLine("-----------------------------------------------");
            foreach (var item1 in array)
            {
                if (item1 % 2 == 0)
                    Console.WriteLine(item1 + " is Even Number");
                else
                    Console.WriteLine(item1 + " is Odd Number");
            }
        }
    }
}
