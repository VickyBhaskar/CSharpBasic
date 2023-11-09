// See https://aka.ms/new-console-template for more information
using System;
namespace SunAndAvgOfArrayEle
{
    internal class program
    {
        static void Main()
        {
            int[] numbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            Console.WriteLine("Array Elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("\n\nSum of Array Elements: " + sum);
            Console.WriteLine("Average of Array Elements: " + average);
        }
    }
}
