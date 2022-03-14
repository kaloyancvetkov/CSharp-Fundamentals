using System;

namespace Problem_10_Pesho_rage_quits_haha
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int counter = 1;

            int brokenHeadset = 0;
            int brokenMouse = 0;
            int brokenKeyboard = 0;
            int brokenDisplay = 0;

            while (counter <= lostGamesCount)
            {
                if (counter % 2 == 0)
                {
                    brokenHeadset += 1;
                }
                if (counter % 3 == 0)
                {
                    brokenMouse += 1;
                }
                if (counter % 6 == 0)
                {
                    brokenKeyboard += 1;
                }
                if (counter % 12 == 0)
                {
                    brokenDisplay += 1;
                }

                counter++;
            }

            double totalExpenses = brokenHeadset * headsetPrice + brokenMouse * mousePrice + brokenKeyboard * keyboardPrice +
                brokenDisplay * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
