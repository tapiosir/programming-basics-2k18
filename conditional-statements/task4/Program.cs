using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("please enter 3 numbers");
                Console.WriteLine();
                
                string userInput = Console.ReadLine();
                string userInput1 = Console.ReadLine();
                string userInput2 = Console.ReadLine();

                bool istrue = int.TryParse(userInput, out int number);
                bool istrue1 = int.TryParse(userInput1, out int number1);
                bool istrue2 = int.TryParse(userInput2, out int number2);
                if (istrue && istrue1 && istrue2)
                { 
                if (number < number1)
                {
                    if (number < number2)
                    {
                        Console.WriteLine($"{number},{number1},{number2}");
                    }
                    else if (number1 < number2)
                    {
                        Console.WriteLine($"{number},{number2},{number1}");
                    }
                    else
                    {
                        Console.WriteLine($"{number2},{number},{number1}");
                    }
                }

                else
                {
                    if (number < number2)
                    {
                        Console.WriteLine($"{number1},{number},{number2}");
                    }
                    else if (number1 < number2)
                    {
                        Console.WriteLine($"{number1},{number2},{number}");
                    }
                    else
                    {
                        Console.WriteLine($"{number2},{number1},{number}");
                    }
                }
                }
                else
                {
                    Console.WriteLine("one of the inputs is not valid");
                }

                Console.ReadKey();
            }

        }
    }
}