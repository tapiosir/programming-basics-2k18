using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string userInput = Console.ReadLine();
            bool istrue = int.TryParse(userInput, out int number);
            if (istrue)
            { 
            if (number > 0)
            {

                if (number % 2 == 0)
                {
                    Console.WriteLine($"number {number} is positive and even");
                }
                else
                {
                    Console.WriteLine($"number {number} is positive and odd");
                }
            }
            if (number < 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"number {number} is negative and even");
                }
                else
                {
                    Console.WriteLine($"number {number} is negative and odd");
                }
            }
            }
            else
            {
                Console.WriteLine($"{userInput} is not valid input");
            }
            Console.ReadKey();
        }
    }
}