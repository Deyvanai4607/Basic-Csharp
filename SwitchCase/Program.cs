using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value 1 : ");
        double value1=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value 2 : ");
        double value2=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Operation : ");
        string operation=Console.ReadLine();
        switch (operation){
            case "+":
            {
                double add=value1+value2;
                Console.WriteLine($"addition values is {add}");
                break;
            }
            case "-":
            {
                double sub=value1-value2;
                Console.WriteLine($"substraction values is {sub}");
                break;
            }
            case "*":
            {
                double mul=value1*value2;
                Console.WriteLine($"multiplication values is {mul}");
                break;
            }
            case "/":
            {
                double div=value1/value2;
                Console.WriteLine($"division values is {div}");
                break;
            }
            case "%":
            {
                double mod=value1%value2;
                Console.WriteLine($"modulo division values is {mod}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid");
                break;
            }
        }
    }
}