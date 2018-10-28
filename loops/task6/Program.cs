using System;

namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double sqrt = 1;

            do
            {
                sqrt = Math.Sqrt(i);
                Console.WriteLine($"{i}\t {sqrt}");
            }
            while (i++ < 10);

            Console.ReadKey();
        }
    }
}