using System;
using System.Collections.Generic;

namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            // Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(i))
                {
                    Console.WriteLine("numbers lists contain {0}", 1);
                }
                else
                {
                    Console.WriteLine($"numbers doesn't contain {i}");
                }
            }
        }
    }
}
