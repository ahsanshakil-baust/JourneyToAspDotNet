using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            string name = "Ahsan";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
                Thread.Sleep(250);
            }

            Console.WriteLine(string.IsNullOrEmpty(name));

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
                Thread.Sleep(250);
            }
        }
    }
}