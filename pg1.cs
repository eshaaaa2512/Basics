using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
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
            Console.WriteLine("Enter the a tenth position:-");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b one position:-");
            b = Convert.ToInt32(Console.ReadLine());
            int num = 10* a + 1 * b;
            Console.WriteLine(num);
            

            Console.ReadLine();
        }
    }
}
            

        














