using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars(PromptUser());
            Console.ReadKey();
        }

        static int PromptUser()
        {
           Console.WriteLine("please enter a positive number");
           string userInput = Console.ReadLine();
           int.TryParse(userInput, out int numberOfStars);
           return numberOfStars;
        } 

        public static void PrintStars(int numberOfStars)
        {
            if (numberOfStars < 0)
            {
                Console.WriteLine($"{numberOfStars} is not a positive number");
            }
            else
            {
                for (int i = 0; i < numberOfStars; i++)
                {
                    Console.Write("*");
                }
            }
        }

    }
}