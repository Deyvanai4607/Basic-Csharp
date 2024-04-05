using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Name : ");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Age : ");
        int age=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject1 : ");
        double mark1=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject2 : ");
        double mark2=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter mark of subject3 : " );
        double mark3=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Grade : ");
        char grade=char.Parse(Console.ReadLine());
        Console.WriteLine("Enter mobile number : ");
        long number=long.Parse(Console.ReadLine());
        Console.WriteLine("Enter mail Id : ");
        string mail=Console.ReadLine();
        Console.WriteLine("Trainee Details are : ");
        Console.WriteLine("Name : "+name);
        Console.WriteLine("Age : "+age);
        Console.WriteLine("Mobile : "+number);
        Console.WriteLine("Mark1 : "+mark1);
        Console.WriteLine("Mark2 : "+mark2);
        Console.WriteLine("Mark3 : "+mark3);
        double total=mark1+mark2+mark3;
        Console.WriteLine("Total : "+total);
        double avg=total/3;
        Console.WriteLine("Average : "+avg);
        Console.WriteLine("Grade : "+grade);
        Console.WriteLine("Mail id : "+mail);
    }
}