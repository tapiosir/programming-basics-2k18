using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumChecker();
            Console.ReadKey();
        }

        public static void NumChecker()
        {
            for (int j = 0; j < 1;)
            {
                Console.WriteLine("please enter a number between 1 and 10");
                string userInput = Console.ReadLine();
                bool isTrue = int.TryParse(userInput, out int num01);
                if (isTrue)
                {
                    if (num01 < 1)
                    {
                        Console.WriteLine("number is too small");
                    }
                    else if (num01 > 10)
                    {
                        Console.WriteLine("number is too large");
                    }
                    else
                    {
                        Console.WriteLine($"number you entered is: {num01}");
                        j++;
                    }
                }
                else
                {
                    Console.WriteLine("invalid charater");
                }
            }
        }
    }
}