using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please enter a number: ");

            string userInput = Console.ReadLine();
            bool isTrue = int.TryParse(userInput, out int number);

            if (isTrue == true)
            {

                if (number % 2 == 0)
                {
                    Console.WriteLine($"number {number} is even");
                }

                else
                {
                    Console.WriteLine($"number {number} is odd");
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
