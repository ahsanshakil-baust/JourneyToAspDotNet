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
        
    }
 }   
}