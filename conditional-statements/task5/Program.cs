using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // prompt user
            Console.Write("enter age");
            Console.WriteLine();
            string userInput = Console.ReadLine();

            //ticket prices
            int ticketPrice = 16;
            double ticketPriceAge = ticketPrice * 0.5;
            double ticketPriceMtk = ticketPrice * 0.85;
            double ticketPriceMili = ticketPrice * 0.5;
            double ticketPriceStud = ticketPrice * 0.55;
            double ticketPriceMtkStud = ticketPrice * 0.40;
            
            bool isTrue = int.TryParse(userInput, out int age);
            if (isTrue) { 
            if (age <= 7)
            {
                Console.WriteLine("ticket is free");
            }
            else if (age >= 65)
            {
                Console.WriteLine($"ticket is {ticketPriceAge:C} ");
            }
            else if (age <= 15)
            {
                Console.WriteLine($"ticket is {ticketPriceAge:C}");
            }
            else
            {
                Console.WriteLine("other discounts? \n 1.servicemen \n 2.member of Mtk \n 3.student \n 4.student and mtk \n 0.none ");

                
                string userInput1 = Console.ReadLine();
                bool isTrue1 = int.TryParse(userInput1, out int discountSelect);

                    if (isTrue1 && discountSelect >= 0 && discountSelect <= 4)
                    {
                        if (discountSelect == 1)
                        {
                            Console.WriteLine($"ticket is {ticketPriceMili:C}");
                        }

                        else if (discountSelect == 2)
                        {
                            Console.WriteLine($"ticket is {ticketPriceMtk:C}");
                        }

                        else if (discountSelect == 3)
                        {
                            Console.WriteLine($"ticket is {ticketPriceStud:C}");
                        }

                        else if (discountSelect == 4)
                        {
                            Console.WriteLine($"ticket is {ticketPriceMtkStud:C}");
                        }

                        else if (discountSelect == 0)
                        {
                            Console.WriteLine($"ticket price is {ticketPrice:C} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{userInput1} was invalid input");
                    }
            }
            }
            else
            {
                Console.WriteLine($"{userInput} is not an age");
            }
            Console.ReadKey();



        }
    }
}