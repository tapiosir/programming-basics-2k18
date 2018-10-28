using System;

namespace task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            int k = 0;

            while (k++ < 4)
            {
                int j = 0;
                Console.Write($"row {k}: ");
                while (j++ < 5)
                {

                    int i = rnd.Next(50);
                    if (j < 5)
                    {
                        Console.Write($"{i.ToString()}\t ");
                    }
                    else
                    {
                        Console.Write($"{i.ToString()}\n");
                    }

                }

            }
        }
    }
}