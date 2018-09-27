using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // prompt user
                Console.Write("please enter 3 numbers");
                Console.WriteLine();

                // Read user input
                string userInput;
                userInput = Console.ReadLine();
                string userInput1;
                userInput1 = Console.ReadLine();
                string userInput2;
                userInput2 = Console.ReadLine();

                // Evaluate user input

                int evaluatedNumber;
                int.TryParse(userInput, out evaluatedNumber);

                int evaluatedNumber1;
                int.TryParse(userInput1, out evaluatedNumber1);

                int evaluatedNumber2;
                int.TryParse(userInput2, out evaluatedNumber2);

                if (evaluatedNumber < evaluatedNumber1)
                {
                    if (evaluatedNumber < evaluatedNumber2)
                    {
                        Console.WriteLine("{0},{1},{2}", evaluatedNumber, evaluatedNumber1, evaluatedNumber2);
                    }
                    else if (evaluatedNumber1 < evaluatedNumber2)
                    {
                        Console.WriteLine("{0},{1},{2}", evaluatedNumber, evaluatedNumber2, evaluatedNumber1);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", evaluatedNumber2, evaluatedNumber, evaluatedNumber1);
                    }
                }

                else
                {
                    if (evaluatedNumber < evaluatedNumber2)
                    {
                        Console.WriteLine("{0},{1},{2}", evaluatedNumber1, evaluatedNumber, evaluatedNumber2);
                    }
                    else if (evaluatedNumber1 < evaluatedNumber2)
                    {
                        Console.WriteLine("{0},{1},{2}", evaluatedNumber1, evaluatedNumber2, evaluatedNumber);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", evaluatedNumber2, evaluatedNumber1, evaluatedNumber);
                    }
                }


                Console.ReadKey();
            }

        }
    }
}
