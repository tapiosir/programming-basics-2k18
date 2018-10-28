using System;
using System.Linq;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int numberOfLetters = userInput.ToCharArray().Count();
            for (int i = 0; i < numberOfLetters; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
        }
    }
}
