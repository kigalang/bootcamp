﻿using System;

namespace helloworld
{

    /*
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            \\Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello there,"+ name);
            

                     


        }
    }
    */

    class Demo 
    {
        static void Main() 
        {
            
            int sum;

            Console.WriteLine ("Let's do some addition:");
            Console.Write("Enter a number: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;        
            //Console.WriteLine("The result is: {0}", sum);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);

        }
    }
}
