using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user
            Console.Write("enter age");
            Console.WriteLine();

            // Read user input
            string userInput;
            userInput = Console.ReadLine();
            int ticketPrice = 16;
            //ticket prices
            double ticketPriceAge = ticketPrice * 0.5;
            double ticketPriceMtk = ticketPrice * 0.85;
            double ticketPriceMili = ticketPrice * 0.5;
            double ticketPriceStud = ticketPrice * 0.55;
            double ticketPriceMtkStud = ticketPrice * 0.40;

            // Evaluate user input

            int age;
            int.TryParse(userInput, out age);

            if (age < 8)
            {
                Console.WriteLine("ticket is free");
            }
            else if (age > 64)
            {
                Console.WriteLine("ticket is {0}€ ", ticketPriceAge);
            }
            else if (age < 16)
            {
                Console.WriteLine("ticket is {0}€", ticketPriceAge);
            }
            else
            {
                Console.WriteLine("other discounts? \n 1.servicemen \n 2.member of Mtk \n 3.student \n 4.student and mtk \n 0.none ");

                string userInput1;
                userInput1 = Console.ReadLine();

                int discountSelect;
                int.TryParse(userInput1, out discountSelect);


                if (discountSelect == 1)
                {
                    Console.WriteLine("ticket is {0}€", ticketPriceMili);
                }

                else if (discountSelect == 2)
                {
                    Console.WriteLine("ticket is {0}€", ticketPriceMtk);
                }

                else if (discountSelect == 3)
                {
                    Console.WriteLine("ticket is {0}€", ticketPriceStud);
                }

                else if (discountSelect == 4)
                {
                    Console.WriteLine("ticket is {0}€", ticketPriceMtkStud);
                }

                else if (discountSelect == 0)
                {
                    Console.WriteLine("ticket price is 16€");
                }

                else
                {
                    Console.WriteLine("invalid charater");
                }
            }
            Console.ReadKey();



        }
    }
}