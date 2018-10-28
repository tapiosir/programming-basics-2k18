using System;

namespace task05
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
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            if (isTrue)
            { 
            if (num01 < 0)
            {
                for (int n = -1; n >= num01; n--)
                {
                    if (n % 2 == 0)
                    {
                        l = l + n;
                    }
                    else
                    {
                        m = m + n;
                    }
                }
                Console.WriteLine($"even numbers sum {l}");
                Console.WriteLine($"odd numbers sum {m}");
            }
            else
            {
                for (int i = 1; i <= num01; i++)
                {
                    if (i % 2 == 0)
                    {
                        j = j + i;
                    }
                    else
                    {
                        k = k + i;
                    }
                }
                Console.WriteLine($"even numbers sum {j}");
                Console.WriteLine($"odd numbers sum {k}");
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
