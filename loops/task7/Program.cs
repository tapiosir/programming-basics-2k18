using System;

namespace task07
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 10;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    Console.WriteLine($"{j}x{i}={i*j}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}