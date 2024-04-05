using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        Console.WriteLine("Even numbers 0 to 25: ");
        while(i<25){
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }
        Console.WriteLine("Enter the number : ");
        Boolean isValid=int.TryParse(Console.ReadLine(),out int number);
        while(!isValid){
            Console.WriteLine("Invalid input format. Please enter the input in number format");
            isValid=int.TryParse(Console.ReadLine(),out number);
        }
        
    }
}