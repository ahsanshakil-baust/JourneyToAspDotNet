using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Password again: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty) && !passwordC.Equals(string.Empty))
            {
                if (password.Length >= 6 && passwordC.Length >= 6)
                {
                    if (password.Equals(passwordC))
                    {
                        Console.WriteLine("Password match");
                    }
                    else
                    {
                        Console.WriteLine("Password don not match");
                    }
                }
                else
                {
                    Console.WriteLine("PPlease enter 6 or more characters!");
                }

            }
            else
            {
                Console.WriteLine("Please enter a password");

            }
        }
    }
}