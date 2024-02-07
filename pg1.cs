using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number:-");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:-");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A is the largest number");
            }
            else
            {
                Console.WriteLine("B is the largest number");
            }
            Console.ReadLine();
        }
    }
}

        
    

