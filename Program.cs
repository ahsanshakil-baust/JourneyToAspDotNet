using System;
using System.Globalization;
using System.Text;

namespace PracticeOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateAndPrintArray();
            Message();
        }

        static void CreateAndPrintArray()
        {
            int[] number = new int[5] { 0, 1, 2, 3, 4 };

            foreach (var item in number)
            {
                Console.WriteLine($"{item}");
            }
        }

        static void Message()
        {
            Console.WriteLine("Welcome");

        }
    }
}