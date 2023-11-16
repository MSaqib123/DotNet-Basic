using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Practice
{
    internal class Program
    {
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int[] Factorize(int num)
        {
            int[] factors = new int[num / 2]; // The maximum number of factors won't exceed num/2

            int factorIndex = 0;

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    factors[factorIndex++] = i;
                    num /= i;
                }
            }

            Array.Resize(ref factors, factorIndex); // Resize the array to fit the actual number of factors
            return factors;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("Please enter a positive integer greater than 1.");
            }
            else
            {
                Console.WriteLine($"Factors of {number}: {string.Join(", ", Factorize(number))}");

                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
        }
    }
}
