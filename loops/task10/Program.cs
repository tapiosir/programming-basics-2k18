using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            double decider = 0;
            for (int i = 1; i <= 13; i++)
            {
                decider = rnd.NextDouble();
                if (decider <= 0.4)
                {
                    Console.WriteLine($"{i}: 1");
                }
                else if (decider <= 0.6)
                {
                    Console.WriteLine($"{i}: x");
                }
                else
                {
                    Console.WriteLine($"{i}: 2");
                }

            }
            Console.ReadKey();
        }
    }
}