using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Console.Write("Enter a number: ");
            // numbers[0] = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter a number: ");
            // numbers[1] = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter a number: ");
            // numbers[2] = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            //     Thread.Sleep(250);
            // }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                Thread.Sleep(250);
            }
        }
    }
}