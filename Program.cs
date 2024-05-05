using System;
using System.Globalization;
using System.Text;

namespace PracticeOne
{
    public class Program
    {
        static string name = "Allu";
        static void Main(string[] args)
        {
            int[] nums = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = ReadNumber();
            }

            foreach (int x in nums)
            {
                Console.WriteLine($"{x}");
            }
            // Console.WriteLine(PrintIntro());
        }

        static int ReadNumber()
        {
            Console.Write("Enter a Number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string PrintIntro()
        {
            return name;
        }
    }
}