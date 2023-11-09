// See https://aka.ms/new-console-template for more information
using System;
namespace NaturalNumber
{
    internal class Program
    {
        static void Main(string[]args)
        {
            
            Console.WriteLine("First 10 Natural Numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nFirst 10 Even Natural Numbers:");
            int counter = 1;
            while (counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.Write(counter + " ");
                }
                counter++;
            }
            Console.WriteLine("\n\nFirst 10 Odd Natural Numbers:");
            int count = 1;
            while (count <= 10)
            {
                if (count % 2 != 0)
                {
                    Console.Write(count + " ");
                }
                count++;
            }
        }
    }
}
