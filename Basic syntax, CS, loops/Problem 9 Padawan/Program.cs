using System;

namespace Problem_9_Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalLightsabersPrice = lightsabersPrice * Math.Ceiling(studentsCount * 1.10);
            double totalRobesPrice = robesPrice * studentsCount;

            int freeBelts = studentsCount / 6;
            double totalBeltsPrice = beltsPrice * studentsCount - freeBelts * beltsPrice;

            double totalPrice = totalLightsabersPrice + totalRobesPrice + totalBeltsPrice;

            if (moneyAmount >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
                Console.WriteLine($"Ivan Cho will need {(totalPrice - moneyAmount):f2}lv more.");

        }
    }
}
