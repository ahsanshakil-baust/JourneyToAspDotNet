using System;

namespace PracticeOne
{
 public class Program{
    static void Main(string[] args){

        // Arrays

        int [] favNums=new int[3];
        favNums[0]=23;
        Console.WriteLine("FavNum 0 : {0}",favNums[0]);

        string[] customers={"Bob","Sally","Sue"};
        var employees=new[] {"Mike","Paul","Rick"};
        object[] randomArray={"Paul",45,1.234};
        Console.WriteLine("Random Array 0 : {0}",randomArray[0].GetType());
        Console.WriteLine("Array Size : {0}",randomArray.Length);
        
        for(int i=0; i<randomArray.Length; i++){
            Console.WriteLine("Array : {0} : Value : {1}",i,randomArray[i]);
            
        }
        Console.WriteLine("-----------------");
        string[,] custNames=new string[2,2] {{"Bob","Smith"},{"Sally","Smith"}};
        Console.WriteLine("MD Value : {0}",custNames.GetValue(1,1));
        
        
    }
 }   
}