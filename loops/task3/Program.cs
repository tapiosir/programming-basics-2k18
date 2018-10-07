using System;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number");
            Console.WriteLine();

            string userInput;
            userInput = Console.ReadLine();

            bool isTrue = int.TryParse(userInput, out int num01);
            int eSum = 0;
            int oSum = 0;
            if (isTrue) { 
            for (int i = 1; i <= num01; i++)
            {
                if (i % 2 == 0)
                {
                    eSum = eSum + i;
                }

                else
                {
                    oSum = oSum + i;
                }


            }
            Console.WriteLine($"even numbers sum {eSum}");
            Console.WriteLine($"odd numbers sum {oSum}");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
        }
    }
}
