﻿using System;

namespace problem_8_triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
