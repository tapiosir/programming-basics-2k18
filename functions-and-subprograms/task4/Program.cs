using System;
using System.Collections.Generic;

namespace task4
{

    class Program
    {
        static void Main(string[] args)
        {
            
            PrintResult(ListCheck(Numbercollect()));
            Console.ReadKey();
        }

        public static int ListCheck(List<int> list)
        {
            Console.WriteLine("you entered numbers: ");
            foreach (var el in list)
                Console.Write($"{el}. ");
            int result = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                result = Math.Max(result, list[i]);
            }
            return result;
        }

        public static void PrintResult(int result)
        {
            Console.WriteLine($"\nLargest input was {result}");
        }

        public static List<int> Numbercollect()
        {
            List<int> list = new List<int>();
            Console.WriteLine("enter 10 numbers");
            
            for (int j = 1; j <= 11;)
            {
                if (j < 11)
                {
                    Console.Write($"{j}: ");
                    string userInput = Console.ReadLine();
                    bool isTrue = int.TryParse(userInput, out int i);
                    if (isTrue)
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
                        Console.WriteLine("invalid character");
                    }
                }
                else
                {
                    
                    return list;
                }
            }
            return null;
        }
    }
}