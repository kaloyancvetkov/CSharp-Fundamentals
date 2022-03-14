using System;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = "";
            bool isBlocked = true;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            for (int i = 1; i < 4; i++)
            {

                
                string password = Console.ReadLine();


                if (password == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    isBlocked = false;
                    break;
                }
                
                    Console.WriteLine("Incorrect password. Try again.");


            }

            if (isBlocked)
            {
                Console.WriteLine($"User {username} blocked!");
            }

        }
    }
}

