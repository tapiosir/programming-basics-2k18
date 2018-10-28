using System;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a positive number");
            Console.WriteLine();

            string userInput;
            userInput = Console.ReadLine();

           bool isTrue = int.TryParse(userInput, out  int num01);
            int i = 1;
            int j = 1;
            if (isTrue)
            { 
            if (num01 < 1)
            {
                Console.WriteLine("number too small");
            }

            else
            {
                while (i++ < num01)
                {
                    j = j + i;
                }
                Console.WriteLine($"{j}");
            }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
        }
    }
}
