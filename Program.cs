using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace PracticeOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int num = 0;
            // bool success = test(out num);
            // Console.WriteLine(num);
            // Console.WriteLine(success);

            List<string> shoppingList = new List<string> { "Coffee", "Milk" };
            // Console.WriteLine(shoppingList.IndexOf("Milk"));
            // Console.WriteLine(FindIndex("Milk", shoppingList, out int index));
            // Console.WriteLine(index);

            if (FindIndex("Milk", shoppingList, out int index))
            {
                Console.WriteLine($"Found at index {index}");

            }
            else
            {
                Console.WriteLine("Not Found");

            }

        }

        static bool FindIndex(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals("coffee"))
                {
                    index = i;
                }

            }

            return index > -1;
        }

        static bool test(out int num)
        {
            num = 5;
            return true;
        }

        static bool TryParse(string s, List<string> list, out int result)
        {
            result = 0;
            return true;
        }

    }
}