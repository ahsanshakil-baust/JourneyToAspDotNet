using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            int num = 7;
            int length = 8;
            int[] result = new int[length];
            int count = 0;

            for (int i = 1; i < result.Length; i++, count++)
            {
                result[count] = num * i;
                Console.WriteLine("numb {0}", count);

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");

            }
        }
    }
}