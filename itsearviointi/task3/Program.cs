using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write numbers and -1 for ending the program");
            int sum = 0;
            for (int i = 0; i < 1; )
            {
                string userInput = Console.ReadLine();
                bool isTrue = int.TryParse(userInput, out int input);
                if (isTrue)
                {
                    if (input == -1)
                    {
                        Console.WriteLine($"sum is {sum}");
                        i++;
                    }
                    sum = input + sum;
                }
            }
        }
    }
}
