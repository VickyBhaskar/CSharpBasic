// See https://aka.ms/new-console-template for more information
using System;
namespace FibonacciSequence
{
    internal class program 
    {
        static void Main(string[]args)
        {
            Console.WriteLine("First 10 Fibonacci Numbers:");

            int n = 10; 

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
