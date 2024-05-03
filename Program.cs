using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<int> listNumber = new List<int>() { 1, 2, 3 };
            foreach (int x in listNumber)
            {
                Console.WriteLine("List : {0}", x);
            }
            listNumber.RemoveAt(1);
            foreach (int x in listNumber)
            {
                Console.WriteLine("List : {0}", x);
            }
        }
    }
}