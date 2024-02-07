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
            int a;
            Console.WriteLine("Enter the number:-");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            Console.ReadLine();
        }
    }
}
        
    

