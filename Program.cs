using System;
using System.Globalization;

namespace PracticeOne
{
    public class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>(){
                {1,"Abbas"},
                {2,"Sabbir"}
            };

            // names.Add(1, "Abbas");
            // names.Add(2, "Sabbir");

            // for (int i = 0; i < names.Count; i++)
            // {
            //     KeyValuePair<int, string> pair = names.ElementAt(i);
            //     Console.WriteLine($"{pair.Key} - {pair.Value}");
            // }


            // if (names.TryGetValue(2, out string name))
            // {
            //     Console.WriteLine(name);
            // }
            // else
            // {
            //     Console.WriteLine("Not Found");
            // }


            if (names.ContainsKey(2))
            {
                names.Remove(2);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


            Console.ReadLine();
        }
    }
}