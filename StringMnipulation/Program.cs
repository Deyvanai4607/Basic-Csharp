using System;
namespace StringMnipulation;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter  longer Main string : ");
        string mainString=Console.ReadLine();
        Console.WriteLine("String to be searched : ");
        string subString=Console.ReadLine();
        String[] newString=mainString.Split(subString);
        Console.WriteLine("string searched count is "+(newString.Length-1));
        
    }
}