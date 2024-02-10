using System;
 prog12

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 main


class program
{
    public static void Main()
    {
        int a, b, i, Sum = 0;
        for (i = 1; i < 100; i++)
        {
 prog12
            a = i % 3;
            b = i % 5;
            if (a == 0 || b == 0)
            {
                Console.Write("{0}", i);
                Sum = Sum + i;
            }

 prog10
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
            

 prog9
            int a, b;
            Console.WriteLine("Enter the a tenth position:-");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b one position:-");
            b = Convert.ToInt32(Console.ReadLine());
            int num = 10* a + 1 * b;
            Console.WriteLine(num);
            


 prog8
            int number, i, fact;
            Console.WriteLine("Enter the number:-");
            number = Convert.ToInt32(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
                Console.WriteLine("The factorial is :- " + (fact));

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
 main
            }
 main
 main
            Console.ReadLine();
 main
 main
        }
        Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}",Sum);
        Console.Read();
    }
}
 prog9
            

 prog7

 prog12










                
        
   


        
    


 main

        





 prog9








prog5
        
       

    
}
 main
 main
        
     main
 main

