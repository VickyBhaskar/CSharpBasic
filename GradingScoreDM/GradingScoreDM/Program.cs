﻿// See https://aka.ms/new-console-template for more information
using System;
namespace GradingScoreDM
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your exam score as a percentage: ");
            double score = Convert.ToDouble(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Your grade is: D");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }
        }
    }
}
