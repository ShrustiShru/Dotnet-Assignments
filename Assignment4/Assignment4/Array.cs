using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements");
                array[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in array)
            {
                Console.WriteLine("The elements of the Array are: " + item);
            }
            
        }
    }
}
