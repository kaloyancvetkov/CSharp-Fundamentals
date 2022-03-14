using System;

namespace problem_6_factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int sum = 0;

            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum = tempNum / 10;
                int currentFactorialSum = 1;
                for (int i = 1; i <= digit; i++)
                {
                    currentFactorialSum *= i;
                }
                sum += currentFactorialSum;
                
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");

            

        }
    }
}
