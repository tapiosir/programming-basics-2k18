using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptUser(out int x, out int y);
            SmallerNumber(x,y);
            Console.ReadKey();
        }

        static void PromptUser(out int num01, out int num02 )
        {
            Console.WriteLine("please enter 2 numbers: ");
            num01 = int.Parse(Console.ReadLine());
            num02 = int.Parse(Console.ReadLine());
        }

        public static void SmallerNumber(int num01, int num02)
        {
            if (num01 < num02)
            {
                Console.WriteLine($"number {num01} is smaller");
            }
            else if (num01 > num02)
            {
                Console.WriteLine($"number {num02} is smaller");
            }
            else
            {
                Console.WriteLine("numbers are equal");
            }
        }


    }
}
