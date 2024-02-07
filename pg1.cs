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
            int number, i, fact;
            Console.WriteLine("Enter the number:-");
            number = Convert.ToInt32(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
                Console.WriteLine("The factorial is :- " + (fact));
            }
            Console.ReadLine();

        }
    }
}


        



    


        
    

