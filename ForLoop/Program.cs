using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter starting number : ");
        int number1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number : ");
        int number2=int.Parse(Console.ReadLine());
        int temp=0;
        for(int i=number1;i<=number2;i++){
            int square=i*i;
            temp=temp+square;
        }
        Console.WriteLine($"sum of the square of the numbers between {number1} and {number2} is "+temp);
    }
}
