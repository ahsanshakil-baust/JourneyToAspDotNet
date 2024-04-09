using System;
using System.Globalization;

namespace PracticeOne
{
 public class Program{

    static void PrintArray(int[] intArray, string mess){
        foreach(int k in intArray){
        Console.WriteLine("{0} : {1}",mess,k);
        }
        
    }

    static void Main(string[] args){
        // Functions

        int[] randNums={1,4,9,2};
        PrintArray(randNums,"ForEach");

        Array.Sort(randNums);
        Array.Reverse(randNums);

        const string textAge="-23";
        int age=Convert.ToInt32(textAge);
        Console.WriteLine("{0}",age);

        double money=-10D / 3D;
        
        Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture));
        Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("bn-BD")));

        
      
    } 
 }   
}