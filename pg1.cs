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
            int a, b, c;
            Console.WriteLine("Enter the first number:-");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:-");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapping a will be :-" + (a));
            Console.WriteLine("After swapping b will be :-" + (b));
            Console.ReadLine();
        }
    }
}

        
       

    
}
        
    

