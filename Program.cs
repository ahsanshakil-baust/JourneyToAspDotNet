using System;
using System.Globalization;

namespace PracticeOne
{

    class Test
    {
        public static void testOne()
        {

            Console.WriteLine("Hello");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Test test = new Test();
            // test.testOne();


            Test.testOne();
            WelcomeMessage();
        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }
    }
}