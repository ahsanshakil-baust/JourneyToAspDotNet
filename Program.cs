using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, value, i * value);
            }
        }
    }
}