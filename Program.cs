using System;

namespace PracticeOne
{
 public class Program{
    static void Main(string[] args){
        bool canVote=true;
        
        Console.WriteLine("Biggest Integer : {0}",int.MaxValue);
        Console.WriteLine("Smallest Integer : {0}", int.MinValue);

        Console.WriteLine("Biggest Long : {0}",long.MaxValue);
        Console.WriteLine("Smallest Long : {0}",long.MinValue);

        decimal decPiVal=3.1415565656556546545M;
        decimal decBigNum=3.00000000000000011M;

        Console.WriteLine("DEC : PI + bigNum = {0}",decPiVal+decBigNum);

        double dblPiVal=3.14165445445745;
        Console.WriteLine("Double PI : {0}",dblPiVal);

        float fltPiVal=3.150000F;
        Console.WriteLine("Float PI : {0}",fltPiVal);

        bool boolFromStr=bool.Parse("true");
        int intFromStr=int.Parse("100");
        Console.WriteLine($"Bool From String : {0}",boolFromStr);
        Console.WriteLine($"Int From String : {0}",intFromStr);
        

        double dblFromStr=double.Parse("1.234");
        string strVal=dblFromStr.ToString();
        Console.WriteLine($"Data type : {strVal.GetType()}");

        double dblNum=12.345;
        Console.WriteLine($"Integer : {(int)dblNum}");
        
        int intNum=10;
        long longNum=intNum;

        Console.WriteLine("Currency : {0:c}",23.4855);
        Console.WriteLine("Pad with 0s : {0:d4}",23);
        Console.WriteLine("3 Decimals : {0:f3}",23.45555);
        Console.WriteLine("Commas : {0:n4}",2300);

        // String Behaviours

        string randString="This is a string";
        Console.WriteLine("String Length : {0}",randString.Length);
        Console.WriteLine("String Contains is : {0}",randString.Contains("is"));
        Console.WriteLine("Index of is : {0}",randString.IndexOf("is"));
        Console.WriteLine("Remove Sring : {0}",randString.Remove(10,6));
        Console.WriteLine("Insert String : {0}",randString.Insert(10,"short"));
        Console.WriteLine("Replace String : {0}",randString.Replace("string","sentence"));
        Console.WriteLine("Compare A to B : {0}",String.Compare("A","B",StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("A = a: {0}",String.Equals("A","a",StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Pad Left : {0}",randString.PadLeft(20,'.'));
        Console.WriteLine("Pad Right : {0}",randString.PadRight(20,'.'));
        Console.WriteLine("Trim : {0}",randString.Trim());
        Console.WriteLine("UpperCase : {0}",randString.ToUpper());
        Console.WriteLine("LowerCase : {0}",randString.ToLower());
        string newString=String.Format("{0} saw a {1} {2} in the {3}","Paul","rabbit","eating","field");
        Console.WriteLine(newString+"\n");

        // \' \" \\ \t \a
        Console.WriteLine(@"Exactly what I typed\n");

    }
 }   
}