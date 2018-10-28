using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input 2 numbers");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);

            Console.WriteLine($"{num1 + num2:N2}\n{num1 - num2:N2}\n{num1 * num2:N2}\n{num1 / num2:N2}");
        }
    }
}
