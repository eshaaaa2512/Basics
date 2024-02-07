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
 prog7
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Enter the limit:-");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {

                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;

 prog5
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

 prog4
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
            Console.WriteLine("Enter the starting number of the range:-");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending number of the range:-");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Odd numbers in the range from" + start + "to " + end + "are");
            PrintOddNumbers(start, end);
        }

        static void PrintOddNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
 prog2
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("The number is odd number");
 main
 main
 main
            }
 main
            Console.ReadLine();
        }
    }
}
 prog7

                
        
   


        
    



        



    


prog5
        
       

    
}
 main
 main
        
    

