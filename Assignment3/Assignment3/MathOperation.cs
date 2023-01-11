using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class MathOperation
    {
        static void Main(string[] args)
        {
            START:
            Console.WriteLine("Enter the 1st number");
            int firstnum=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            int secondnum=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator");
            var choice=Console.ReadLine();

            while(true)
            {
                switch(choice)
            {
                    case "+":
                        var add = firstnum + secondnum;
                        Console.WriteLine($"Addition of the two numbers is:  {add}" );
                        break;

                    case "*":
                        var multi = firstnum * secondnum;
                        Console.WriteLine($"Multiplication of the two numbers is:   {multi}");
                        break;

                    case "-":
                        var sub = firstnum - secondnum;
                        Console.WriteLine($"Subtraction of the two numbers is:   {sub}");
                        break;

                    case "/":
                        float div = firstnum / secondnum;
                        Console.WriteLine($"Division of the two numbers is:   {div}");
                        break;

                    default:
                        throw new Exception("Invalid Output");
                        break;
            }
                goto START;   
            }
        }
    }
}
