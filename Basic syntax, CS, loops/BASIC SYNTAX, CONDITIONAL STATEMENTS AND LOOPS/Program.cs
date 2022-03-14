using System;

namespace BASIC_SYNTAX__CONDITIONAL_STATEMENTS_AND_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            decimal pricePerPerson = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 8.45M;
                            break;

                        case "Saturday":
                            pricePerPerson = 9.80M;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46M;
                            break;




                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 10.90M;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60M;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;


                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50M;
                            break;

                            
                    }
                    break;


            }


            decimal totalPrice = pricePerPerson * groupOfPeople;
            switch (typeOfGroup)
            {
                case "Students":
                    if (groupOfPeople >= 30)
                    {
                        totalPrice = 0.85M * totalPrice;
                    }
                    break;
                case "Business":
                    if (groupOfPeople >= 100)
                    {
                        totalPrice -= 10 * pricePerPerson;
                    }
                    break;
                case "Regular":
                    if (groupOfPeople >= 10 && groupOfPeople <= 20)
                    {
                        totalPrice = 0.95M * totalPrice;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");


        }
    }
}
