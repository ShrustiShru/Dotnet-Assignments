using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The range of float is {float.MinValue} and {float.MaxValue}");
            Console.WriteLine($"The range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The range of double is {double.MinValue} and {double.MaxValue}");
            Console.WriteLine($"The range of decimal is {decimal.MinValue} and {decimal.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} and {long.MaxValue}");
            Console.WriteLine($"The range of short or Int16 is {short.MinValue} and {short.MaxValue}");
            //Console.WriteLine($"The range of Int16 is {Int16.MinValue} and {Int16.MaxValue}");
            Console.WriteLine($"The range of Int64 is {Int64.MinValue} and {Int64.MaxValue}");
            Console.WriteLine($"The range of byte is {byte.MinValue} and {byte.MaxValue}");
        }
    }
}
