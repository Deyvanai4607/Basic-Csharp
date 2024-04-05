using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string[] nameArray=new string[5]{"Mani", "Ganesh", "Venkat", "Suresh", "Venkat"};
        for(int j=0;j<nameArray.Length;j++){
           Console.WriteLine(nameArray[j]);
        }
        Console.WriteLine("Enter name for search : ");
        string name=Console.ReadLine();
        Boolean result=false;
        int indexValue=0;
        for(int k=0;k<5;k++){
            if(name==nameArray[k]){
                 result=true; 
                 indexValue=k; 
                 break;  
            }
        }
        if(result==true){
            Console.WriteLine("The name is present in array");
            Console.WriteLine("index value of that name is : "+indexValue);
        }else{
            Console.WriteLine("The name is not present in array");
        }
        foreach(string i in nameArray){
            if(name==i){
                result=true;
                break;
            }
        }
        if(result==true){
            Console.WriteLine("The name is present in array");
            
        }else{
            Console.WriteLine("The name is not present in array");
        }

        
    }
}
                