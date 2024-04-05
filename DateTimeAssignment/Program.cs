using System;
using System.Net.Mail;
namespace DateTimeAssignment;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);
        Console.WriteLine(date.ToString("dd/MM/yyy hh:mm:ss"));
        string datestr=date.ToString("dd/MM/yyy hh:mm:ss");
        string[] dateArray=datestr.Split('/',':',' ');
        for(int i=dateArray.Length-1;i>=0;--i){
            Console.Write(dateArray[i]+" ");
            
        }
        Console.WriteLine();
        Console.WriteLine("Enter date (yyyy/MM/dd hh:mm:ss tt) :");
        DateTime newDate=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        Console.WriteLine(newDate.ToString("yyyy/MM/dd"));

    }
}