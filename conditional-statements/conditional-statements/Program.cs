using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string userInput = Console.ReadLine();


            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber)
            {
                if (number > 0)
                {
                    Console.WriteLine($"number {number} is positive");
                }

                else if (number < 0)
                {
                    Console.WriteLine($"number {number} is negative");
                }

                else
                {
                    Console.WriteLine($"number is {number}");
                }
            }
            else
                Console.WriteLine($"{userInput} is not a number");

            Console.ReadKey();

        }
    }
}