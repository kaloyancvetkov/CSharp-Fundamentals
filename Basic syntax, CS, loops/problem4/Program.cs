using System;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (startNumber <= endNumber)
            {
                Console.Write(startNumber + " ");
                sum += startNumber;
                startNumber++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
