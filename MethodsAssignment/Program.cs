using System;
namespace MethodsAssignment;
class Program{
    public static void Main(string[] args)
    {
        String repeat=" ";
        do{
            Console.Write("Enter number 1 : ");
            double number1=double.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            double number2=double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the mathematical operation : " );
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            string option=Console.ReadLine();
            switch(option){
                case "Addition":{
                    Console.WriteLine($"Addition value is : {Addition(number1,number2)}");
                    break;
                }
                case "Subtraction":{
                    Console.WriteLine($"Subtraction value is : {Subtraction(number1,number2)}");
                    break;
                }
                case "Multiplication":{
                    Console.WriteLine($"Multiplication value is : {Multiplication(number1,number2)}");
                    break;
                }
                case "Division":{
                    Console.WriteLine($"Division value is : {Division(number1,number2)}");
                    break;
                }
                default:{
                    Console.WriteLine("Invalid Input");
                    break;
                }

            }
            Console.WriteLine("do you wants to continue this operation again ? yes/no");
            repeat=Console.ReadLine();
        }while(repeat=="yes");
        
    }
    static double Addition(double num1,double num2){
        return num1+num2;
    }static double Subtraction(double num1,double num2){
        return num1-num2;
    }static double Multiplication(double num1,double num2){
        return num1*num2;
    }
    static double Division(double num1,double num2){
        return num1/num2;
    }
}