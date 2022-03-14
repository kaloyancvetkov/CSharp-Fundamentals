using System;

namespace problem7_vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            bool invalid = false;
            decimal coinsSum = 0;

            while (coin != "Start")
            {
                switch (coin)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        coinsSum += decimal.Parse(coin);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }

                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();
            decimal productPrice = 0;

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0M;
                        break;
                    case "Water":
                        productPrice = 0.7M;
                        break;
                    case "Crisps":
                        productPrice = 1.5M;
                        break;
                    case "Soda":
                        productPrice = 0.8M;
                        break;
                    case "Coke":
                        productPrice = 1.0M;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        invalid = true;
                        break;

                }

                if (coinsSum >= productPrice)
                {
                    if (!invalid)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coinsSum -= productPrice;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinsSum:f2}");
        }
    }
}
