using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num6Calculator = 0;
            int die;

            for (int i = 0; i < 1000; i++)
            {
                die = rnd.Next(1, 7);
                if (die == 6)
                {
                    num6Calculator++;
                }
               
                Console.WriteLine($"{i}: {die}");

            }
            Console.WriteLine($"number 6 was threw {num6Calculator} times");
            Console.ReadKey();
        }
    }
}