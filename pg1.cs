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
            int i;
            Console.WriteLine("Enter the number:-");
            i= Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd number");
            }
            Console.ReadLine();
        }
    }
}
