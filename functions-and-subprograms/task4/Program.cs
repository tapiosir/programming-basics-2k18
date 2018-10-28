using System;

namespace task4
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            NumberCollector();
            Console.ReadKey();
        }

        public static void NumberCollector()
        {
            List<int> list = new List<int>();
            Console.WriteLine("enter 10 numbers");
            for (int j = 1; j <= 11;)
            {
                if (j == 11)
                {
                    j++;
                    Console.WriteLine("you entered numbers: ");
                    foreach (var el in list)
                        Console.Write($"{el}. ");
                    int max = list[0];
                    for (int i = 1; i < list.Count; i++)
                    {
                        max = Math.Max(max, list[i]);
                    }
                    Console.WriteLine($"\nlargest input was {max}");
                }
                else
                {
                    Console.Write($"{j}: ");
                    string userInput = Console.ReadLine();
                    bool isTrue = int.TryParse(userInput, out int i);
                    if (isTrue )
                    {
                        if (i < 0)
                        {
                            Console.WriteLine($"number {i} is negative, please enter positive number");
                        }
                        else
                        {
                            j++;
                            list.Add(i);
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
}