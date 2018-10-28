using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
        }
    }
}
