using System;
using System.Globalization;

namespace JessicaZanon_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|      Airline Ticket Purchase      |");
            Console.WriteLine("-------------------------------------");

            Console.Write("Enter a destination: ");
            string destination = Console.ReadLine();
            Console.Write("Ticket Value: $ ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many people: ");
            int people = int.Parse(Console.ReadLine());
            double originalValue = people * value;
            double amountAfterFirstDiscount;
            double amountAfterSecondDiscount;

            if (people < 2)
            {
                Console.WriteLine("The number of people must be greater than 1.");
            }
            else
            {
                // Discount 1

                if (value <= 1000)
                    amountAfterFirstDiscount = originalValue - (originalValue * 0.1);
                else 
                    amountAfterFirstDiscount = originalValue - (originalValue * 0.15);

                // Discount 2

                if (people <= 10)
                    amountAfterSecondDiscount = amountAfterFirstDiscount - (amountAfterFirstDiscount * 0.05);
                else
                {
                    double aggregateDiscountPercentage = people * 0.005;

                    if (aggregateDiscountPercentage > 0.25)
                        aggregateDiscountPercentage = 0.25;

                    amountAfterSecondDiscount = amountAfterFirstDiscount - (amountAfterFirstDiscount * aggregateDiscountPercentage);

                }
                Console.WriteLine($"Your destination is {destination}, the number of people is {people} and the final value is {amountAfterSecondDiscount}.");



            }
            Console.ReadLine();
        }   

    }

}

