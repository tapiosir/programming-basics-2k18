using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a positive number");
            Console.WriteLine();

            string userInput;
            userInput = Console.ReadLine();

            
            bool isTrue = int.TryParse(userInput, out int num01);
            int j = 1;
            if (isTrue) { 
            if (num01 < 0)
            {
                Console.WriteLine("number was negative");
            }

            else
            {
                for (int i = 1; i <= num01; i++)
                {
                    j = j * i;
                }

                Console.WriteLine($"{j}");
            }
            }
            else
            {
                Console.WriteLine($"{userInput} was not a proper input");
            }

            Console.ReadKey();
        }
    }
}
