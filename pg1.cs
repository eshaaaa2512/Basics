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
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number-");
            b=Convert.ToInt32(Console.ReadLine());
            
            int sum = a + b;



            
            int mul = a * b;
            
            float div = a / b;
            Console.WriteLine("Sum of the number:" + (sum));
            Console.WriteLine("The multiplication of the number is:"  + (mul));
            Console.WriteLine("The division of the number is:" + (div));
            Console.ReadLine();
            

        }
    }
}


        



    


        
    

