using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace PracticeOne
{
    public class Program
    {
        static string name = "Allu";
        static void Main(string[] args)
        {
            // int[] nums = new int[3];

            // int first = ReadNumber();
            // int second = ReadNumber();

            // Console.WriteLine(Add(a: second, b: first));


            // for (int i = 0; i < nums.Length; i++)
            // {
            //     nums[i] = ReadNumber();
            // }

            // foreach (int x in nums)
            // {
            //     Console.WriteLine($"{x}");
            // }
            // Console.WriteLine(PrintIntro());
            string name = ReadUserDetails("Enter Your Name");
            string age = ReadUserDetails("ENter Your Age");

            Console.WriteLine(UserDetails(name, age));

        }

        // static int Add(int a, int b = default)
        // {
        //     return a + b;
        // }


        // static int Add(int a, int b = 0)
        // {
        //     return a + b;
        // }


        static int Add(int a, [Optional] int b)
        {
            return a + b;
        }

        static string UserDetails(string name, string age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }

        static int ReadNumber()
        {
            Console.Write("Enter a Number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReadUserDetails(string message)
        {
            Console.Write($"{message} : ");
            return Console.ReadLine();
        }

        static string PrintIntro()
        {
            return name;
        }
    }
}